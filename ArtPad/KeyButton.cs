﻿//#define DODEBUG

using KEUtils.About;
using KEUtils.ScrolledHTML2;
using KEUtils.Utils;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace ArtPad {
    public partial class KeyButton : Button {
        private string LF = System.Environment.NewLine;
        private static EditKeyDialog editKeyDlg;
        private static ScrolledHTMLDialog2 overviewDlg;
        private KeyDef keyDef;

        public KeyButton(KeyDef key) {
            keyDef = key;
            InitializeComponent();
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            // Use this for showing the context menu because OnClick
            // apparently does not get right mouse events
#if DODEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseUp ("
                + keyDef.Row + "," + keyDef.Col + ")");
#endif
            // See if it is a right click
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right) {
                // Adjust the visibility of the control items
                ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
                if (artPad.Config.TitleBarType == 0) {
                    toolStripMenuItemMove.Visible = false;
                    toolStripMenuItemMove.Enabled = false;
                    toolStripMenuItemSize.Visible = false;
                    toolStripMenuItemSize.Enabled = false;
                    toolStripMenuItemRestore.Visible = false;
                    toolStripMenuItemRestore.Enabled = false;
                    toolStripMenuItemMinimize.Visible = false;
                    toolStripMenuItemMinimize.Enabled = false;
                    toolStripMenuItemMaximize.Visible = false;
                    toolStripMenuItemMaximize.Enabled = false;
                    toolStripMenuItemExit.Visible = false;
                    toolStripMenuItemExit.Enabled = false;
                    toolStripSeparatorControls.Visible = false;
                } else {
                    toolStripMenuItemMove.Visible = true;
                    toolStripMenuItemMove.Enabled = true;
                    toolStripMenuItemSize.Visible = true;
                    toolStripMenuItemSize.Enabled = true;
                    toolStripMenuItemRestore.Visible = true;
                    toolStripMenuItemRestore.Enabled = true;
                    toolStripMenuItemMinimize.Visible = true;
                    toolStripMenuItemMinimize.Enabled = true;
                    toolStripMenuItemMaximize.Visible = true;
                    toolStripMenuItemMaximize.Enabled = true;
                    toolStripMenuItemExit.Visible = true;
                    toolStripMenuItemExit.Enabled = true;
                    toolStripSeparatorControls.Visible = true;
                }

                // Show the context menu
                contextMenuStrip.Show(this, me.X, me.Y);
                return;
            }
            base.OnMouseUp(e);
        }

        protected override void OnMouseEnter(System.EventArgs e) {
#if DODEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseEnter ("
                + keyDef.Row + "," + keyDef.Col + ")");
#endif
            // Save the foreground window here
            Tools.saveForegroundWindow();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
#if DODEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseLeave ("
                + keyDef.Row + "," + keyDef.Col + ")");
#endif
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.DoMouseDown(e);
#if DODEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseDown ("
                + keyDef.Row + "," + keyDef.Col + ")");
#endif
        }

        protected override void OnClick(System.EventArgs e) {
#if DODEBUG && false
            Tools.debugForegroundWindows("KeyButton.OnClick");
#endif
            Tools.setForegroundWindowFromSaved();
#if DODEBUG && false
            Tools.debugForegroundWindows("KeyButton.OnClick (After)");
            debug.print("KeyButton.OnClick (After): Sending: " + keyConfig.KeyString);
#endif
            switch (keyDef.Type) {
                case KeyDef.KeyType.NORMAL:
                    handleNormalKey(e);
                    break;
                case KeyDef.KeyType.COMMAND:
                    handleCommandKey(e);
                    break;
                case KeyDef.KeyType.HOLD:
                    handleHoldKey(e);
                    break;
                case KeyDef.KeyType.UNUSED:
                    // Do nothing
                    break;
                default:
                    Utils.errMsg("Unhandled key type: " + keyDef.Type);
                    return;
            }
        }

        /// <summary>
        /// Handles a NORMAL key
        /// </summary>
        /// <param name="e"></param>
        protected void handleNormalKey(System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            if (!artPad.Handle.Equals(Tools.HForegroundWindow)) {
                try {
                    SendKeys.Send(keyDef.KeyString);
                } catch (Exception ex) {
                    Utils.excMsg("Error invoking COMMAND for key "
                        + keyDef.Name, ex);
                }
            }
        }

        /// <summary>
        /// Handles a COMMAND key
        /// </summary>
        /// <param name="e"></param>
        protected void handleCommandKey(System.EventArgs e) {
            // Process the string to get the filename and arguments
            var tokens = (keyDef.KeyString).Split(',');
            if (tokens.Length == 0) {
                Utils.errMsg("key " + keyDef.Name + " has no command");
            } else {
                // Send the KeyString as a command
                try {
                    var process = new Process {
                        StartInfo = new ProcessStartInfo {
                            FileName = tokens[0],
                            Arguments = tokens.Length > 1 ? tokens[1] : ""
                        }
                    };
                    process.Start();
                } catch (System.Exception ex) {
                    Utils.excMsg("Error invoking COMMAND for key "
                        + keyDef.Name, ex);
                }
            }
#if DODEBUG && false
            Tools.debugForegroundWindows("handleCommandKey (After)");
#endif
        }

        /// <summary>
        /// Handles a HOLD key
        /// </summary>
        /// <param name="e"></param>
        protected void handleHoldKey(System.EventArgs e) {
            VirtualKeyCode keyCode;
            try {
                keyCode = Tools.getKeyCode(keyDef);
            } catch (System.ArgumentException) {
                Utils.errMsg("Cannot handle HOLD for " + keyDef.KeyString
                    + LF + "Must be ^ (Ctrl), % (Alt), or + (Shift)");
                return;
            }

            var sim = new InputSimulator();
            try {
                if (keyDef.Pressed) {
                    keyDef.Pressed = false;
                    sim.Keyboard.KeyUp(keyCode);
                    // Use this instead of 
                    // BackColor = Color.FromKnownColor(KnownColor.Control);
                    ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
                    Configuration config = artPad.Config;
                    if (config.isValidBGColorString()) {
                        BackColor = config.getBgColor();
                    } else {
                        UseVisualStyleBackColor = true;
                    }
                } else {
                    sim.Keyboard.KeyDown(keyCode);
                    keyDef.Pressed = true;
                    BackColor = Color.FromKnownColor(KnownColor.Highlight);
                }
            } catch (Exception ex) {
                Utils.excMsg("Error invoking COMMAND for key "
                        + keyDef.Name, ex);
            }
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            if (artPad.Config.TitleBarType != 1) return;
            if (artPad.moving) {
                toolStripMenuItemMove.Text = "Disable moving";
            } else {
                toolStripMenuItemMove.Text = "Enable moving";
            }
            if (artPad.sizing) {
                toolStripMenuItemSize.Text = "Disable sizing";
            } else {
                toolStripMenuItemSize.Text = "Enable sizing";
            }
        }

        void toolStripMenuItemLoad_Click(object sender, System.EventArgs e) {
            // Displays an OpenFileDialog so the user can select a 
            // KeyConfiguration
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Configuration Files|*.config";
            dlg.Title = "Select a Configuration File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                toolStripMenuItemMove.Checked = false;
                toolStripMenuItemSize.Checked = false;
                artPad.reconfigure(dlg.FileName);
            }
        }

        private void toolStripMenuItemSaveAs_Click(object sender, System.EventArgs e) {
            // Displays an OpenFileDialog so the user can select a 
            // KeyConfiguration
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.Config.setSizeForKeySize(Width, Height);
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Configuration Files|*.config";
            dlg.Title = "Select a Configuration File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Configuration.writeConfig(artPad.Config, dlg.FileName);
            }
        }

        private void toolStripMenuItemEdit_Click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            // Create, show, or set visible the EditKeyDialog as appropriate
            if (editKeyDlg == null) {
                editKeyDlg = new EditKeyDialog(keyDef, artPad);
                editKeyDlg.Show();
            } else {
                editKeyDlg.Visible = true;
                editKeyDlg.resetContents(keyDef, artPad);
            }
        }

        private void toolStripMenuItemDeleteRow_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.deleteRow(keyDef.Row);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemAddRowBefore_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertRowBefore(keyDef.Row);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemAddRowAfter_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertRowAfter(keyDef.Row);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemDeleteCol_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.deleteCol(keyDef.Col);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemAddColBefore_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertColBefore(keyDef.Col);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemAddColAfter_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertColAfter(keyDef.Col);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemSort_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.sort();
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemCreateNew_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            NumericEntry2Dialog dlg = new NumericEntry2Dialog();
            dlg.Text = "Contents";
            dlg.Label1.Text = "Rows";
            dlg.Label2.Text = "Columns";
            dlg.NumericUpDown1.Value = artPad.Config.Rows;
            dlg.NumericUpDown2.Value = artPad.Config.Cols;
            if (dlg.ShowDialog() == DialogResult.OK) {
                Configuration config =
                    Configuration.generateNewConfiguration((int)dlg.NumericUpDown1.Value,
                    (int)dlg.NumericUpDown2.Value);
                config.setSizeForKeySize(Width, Height);
                artPad.reconfigure(config);
            }
        }

        private void toolStripMenuItemAppearance_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            AppearanceDialog dlg = new AppearanceDialog();
            dlg.Text = "Appearance";
            dlg.LabelFontName.Text = "Font Name";
            dlg.LabelFontSize.Text = "Font Size (pt)";
            System.Drawing.Text.InstalledFontCollection installedFontCollection =
                new System.Drawing.Text.InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;
            int count = fontFamilies.Length;
            int selectedIndex = -1;
            string name;
            for (int i = 0; i < count; i++) {
                name = fontFamilies[i].Name;
                dlg.ComboBoxFontName.Items.Add(name);
                if (name.Equals(config.FontName)) {
                    selectedIndex = i;
                }
            }
            dlg.ComboBoxFontName.SelectedIndex = selectedIndex;

            dlg.CheckBoxBold.Checked = config.FontFlags.Bold;
            dlg.CheckBoxItalic.Checked = config.FontFlags.Italic;
            dlg.CheckBoxUnderline.Checked = config.FontFlags.Underline;
            dlg.CheckBoxStrikeout.Checked = config.FontFlags.Strikeout;

            dlg.NumericUpDownFontSize.DecimalPlaces = 1;
            dlg.NumericUpDownFontSize.Value = (Decimal)config.FontSize;

            dlg.TextBoxFg.Text = config.FgColorString;
            dlg.TextBoxBg.Text = config.BgColorString;

            if (config.TitleBarType > 1) {
                config.TitleBarType = 0;
            }
            dlg.ComboBoxTitleBar.SelectedIndex = config.TitleBarType;

            dlg.LabelWidth.Text = "Key Width";
            dlg.LabelHeight.Text = "Key Height";
            dlg.NumericUpDownWidth.Value = Width;
            dlg.NumericUpDownHeight.Value = Height;

            if (dlg.ShowDialog() == DialogResult.OK) {
                config.FontName = dlg.ComboBoxFontName.Text;
                config.FontSize = (float)dlg.NumericUpDownFontSize.Value;
                config.setFontStyle(dlg.CheckBoxBold.Checked,
                    dlg.CheckBoxItalic.Checked,
                    dlg.CheckBoxUnderline.Checked,
                    dlg.CheckBoxStrikeout.Checked);
                config.FgColorString = dlg.TextBoxFg.Text;
                config.BgColorString = dlg.TextBoxBg.Text;
                config.TitleBarType = dlg.ComboBoxTitleBar.SelectedIndex;
                config.setSizeForKeySize((int)dlg.NumericUpDownWidth.Value,
                    (int)dlg.NumericUpDownHeight.Value);
                artPad.reconfigure(config);
            }
        }

        private void toolStripMenuItemHoldKeysUp_click(object sender, System.EventArgs e) {
            try {
                ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
                Configuration config = artPad.Config;
                Tools.sendUpEventsForPressedKeys(config.KeyDefs);
                artPad.reconfigure(config);
            } catch (System.Exception ex) {
                Utils.excMsg("Error sending key up events", ex);
            }
        }

        private void toolStripMenuItemCopyKey_click(object sender, System.EventArgs e) {
            try {
                string json =
                    JsonConvert.SerializeObject(keyDef, Formatting.Indented);
                Clipboard.SetText(json);
            } catch (System.Exception ex) {
                Utils.excMsg("Error sending key up events", ex);
            }
        }

        private void toolStripMenuItemPasteKey_click(object sender, System.EventArgs e) {
            IDataObject ClipData = Clipboard.GetDataObject();
            if (!ClipData.GetDataPresent(DataFormats.Text)) {
                Utils.errMsg("Clipboard does not contain a key definition");
                return;
            }
            string json = Clipboard.GetData(DataFormats.Text).ToString();
            KeyDef newKeyDef;
            try {
                newKeyDef = JsonConvert.DeserializeObject<KeyDef>(json);
            } catch (Exception ex) {
                Utils.excMsg(
                    "Error converting clipboard contents to a "
                    + "key definition", ex);
                return;
            }
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            newKeyDef.Row = keyDef.Row;
            newKeyDef.Col = keyDef.Col;
            int index = config.KeyDefs.FindIndex(
                keyDef =>
                keyDef.Row == newKeyDef.Row && keyDef.Col == newKeyDef.Col);
            if (index == -1) {
                Utils.errMsg("Error finding key definition to set");
                return;
            }
            config.setSizeForKeySize(Width, Height);
            config.KeyDefs[index] = newKeyDef;
            artPad.reconfigure(config);
        }

        private void toolStripMenuItemOverview_click(object sender, System.EventArgs e) {
            // Create, show, or set visible the overview dialog as appropriate
            if (overviewDlg == null) {
                ArtPadForm app = (ArtPadForm)FindForm().FindForm();
                overviewDlg = new ScrolledHTMLDialog2(
                    Utils.getDpiAdjustedSize(app, new Size(800, 600)),
                    "Overview", @"Help\Overview.html");
                overviewDlg.Show();
            } else {
                overviewDlg.Visible = true;
            }
        }

        private void toolStripMenuItemOverviewOnlineClick(object sender, EventArgs e) {
            try {
                Process.Start("https://kenevans.net/opensource/ArtPad/Help/Overview.html");
            } catch (Exception ex) {
                Utils.excMsg("Failed to start browser", ex);
            }
        }

        private void toolStripMenuItemAbout_click(object sender, System.EventArgs e) {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Image image = null;
            try {
                image = Image.FromFile(@".\Help\ArtPad.256x256.png");
            } catch (Exception ex) {
                Utils.excMsg("Failed to get AboutBox image", ex);
            }
            AboutBox dlg = new AboutBox(image, assembly);
            dlg.ShowDialog();
        }

        private void toolStripMenuItemArtPadTopmost_click(object sender, EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.TopMost = true;
        }

        private void toolStripMenuItemApplicationNotTopmost_Click(object sender, EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            if (Tools.HForegroundWindow == IntPtr.Zero) {
                Utils.errMsg("The current foreground window is undefined");
                return;
            }
            if (artPad.Handle.Equals(Tools.HForegroundWindow)) {
                Utils.errMsg("The current foreground window is ArtPad");
                return;
            }
            try {
                NativeMethods.SetWindowPos(Tools.HForegroundWindow,
                    NativeMethods.HWND_NOTOPMOST, 0, 0, 0, 0,
                    NativeMethods.SWP_NOMOVE | NativeMethods.SWP_NOSIZE |
                    NativeMethods.SWP_SHOWWINDOW);
                Utils.infoMsg("Set window to not be Topmost\n"
                    + String.Format("HWND=0x{0}\n",
                    Tools.HForegroundWindow.ToString("X8"))
                    + "Title: " + Tools.getWindowTitle(Tools.HForegroundWindow));
            } catch (Exception ex) {
                Utils.excMsg("Failed to set foreground window to not be topmost",
                    ex);
                return;
            }
        }

        private void toolStripMenuItemApplicationTopmost_Click(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            if (Tools.HForegroundWindow == IntPtr.Zero) {
                Utils.errMsg("The current foreground window is undefined");
                return;
            }
            if (artPad.Handle.Equals(Tools.HForegroundWindow)) {
                Utils.errMsg("The current foreground window is ArtPad");
                return;
            }
            try {
                NativeMethods.SetWindowPos(Tools.HForegroundWindow,
                    NativeMethods.HWND_TOPMOST, 0, 0, 0, 0,
                    NativeMethods.SWP_NOMOVE | NativeMethods.SWP_NOSIZE |
                    NativeMethods.SWP_SHOWWINDOW);
                Utils.infoMsg("Set window to be Topmost\n"
                    + String.Format("HWND=0x{0}\n",
                    Tools.HForegroundWindow.ToString("X8"))
                    + "Title: " + Tools.getWindowTitle(Tools.HForegroundWindow));
            } catch (Exception ex) {
                Utils.excMsg("Failed to set foreground window to be topmost", ex);
                return;
            }
        }

        private void toolStripMenuItemShowForegroundWin_Click(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            try {
                Utils.infoMsg("ArtPad Window\n"
                    + String.Format("HWND=0x{0}\n", artPad.Handle.ToString("X8"))
                    + "Topmost=" + Tools.getWindowIsTopmost(artPad.Handle) + "\n"
                    + "Title: " + Tools.getWindowTitle(artPad.Handle)
                    + "\n\nForeground Window\n"
                    + String.Format("HWND=0x{0}\n",
                    Tools.HForegroundWindow.ToString("X8"))
                    + "Topmost="
                    + Tools.getWindowIsTopmost(Tools.HForegroundWindow) + "\n"
                    + "Title: " + Tools.getWindowTitle(Tools.HForegroundWindow));
            } catch (Exception ex) {
                Utils.excMsg("Failed to show foreground window", ex);
                return;
            }
        }

        private void toolStripMenuItemDoMove(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.moving = !artPad.moving;
            if (artPad.moving) {
                artPad.moving = true;
            } else {
                artPad.moving = false;
            }
        }

        private void toolStripMenuItemDoSize(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            if (artPad.Config.TitleBarType == 1) {
                artPad.sizing = !artPad.sizing;
                if (artPad.sizing) {
                    artPad.FormBorderStyle = FormBorderStyle.Sizable;
                } else {
                    artPad.FormBorderStyle = FormBorderStyle.None;
                }
            }
        }

        private void toolStripMenuItemDoMimimize(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItemDoMaximize(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItemDoRestore(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItemDoExit(object sender,
            EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            artPad.Close();
        }

    }
}
