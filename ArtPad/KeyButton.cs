using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsInput;
using WindowsInput.Native;

namespace ArtPad {
    public partial class KeyButton : Button {
        private string LF = System.Environment.NewLine;
        private static EditKeyDialog editKeyDlg;
        private static ScrolledHTMLDialog overviewDlg;
        private KeyDef keyDef;

        public KeyButton(KeyDef key) {
            keyDef = key;
            InitializeComponent();

            // Should have been able to do this in the designer
            toolStripMenuItemLoad.Click +=
                new System.EventHandler(toolStripMenuItemLoad_Click);
            toolStripMenuItemSaveAs.Click +=
                new System.EventHandler(toolStripAsMenuItemSaveAs_Click);
            toolStripMenuItemEditKey.Click +=
                new System.EventHandler(toolStripMenuItemEdit_Click);
            toolStripMenuItemDeleteRow.Click +=
                new System.EventHandler(toolStripMenuItemDeleteRow_click);
            toolStripMenuItemAddRowBefore.Click +=
                new System.EventHandler(toolStripMenuItemAddRowBefore_click);
            toolStripMenuItemAddRowAfter.Click +=
                new System.EventHandler(toolStripMenuItemAddRowAfter_click);
            toolStripMenuItemDeleteCol.Click +=
                new System.EventHandler(toolStripMenuItemDeleteCol_click);
            toolStripMenuItemAddColBefore.Click +=
                new System.EventHandler(toolStripMenuItemAddColBefore_click);
            toolStripMenuItemAddColAfter.Click +=
                new System.EventHandler(toolStripMenuItemAddColAfter_click);
            toolStripMenuItemSort.Click +=
                new System.EventHandler(toolStripMenuItemSort_click);
            toolStripMenuItemCreateNew.Click +=
                new System.EventHandler(toolStripMenuItemCreateNew_click);
            toolStripMenuItemSetKeySize.Click +=
                new System.EventHandler(toolStripMenuItemSetKeySize_click);
            toolStripMenuItemHoldKeysUp.Click +=
                new System.EventHandler(toolStripMenuItemHoldKeysUp_click);
            toolStripMenuItemCopyKey.Click +=
                new System.EventHandler(toolStripMenuItemCopyKey_click);
            toolStripMenuItemPasteKey.Click +=
                new System.EventHandler(toolStripMenuItemPasteKey_click);
            toolStripMenuItemOverview.Click +=
                new System.EventHandler(toolStripMenuItemOverview_click);
            toolStripMenuItemAbout.Click +=
                new System.EventHandler(toolStripMenuItemAbout_click);
        }

        void toolStripMenuItemLoad_Click(object sender, System.EventArgs e) {

            // Displays an OpenFileDialog so the user can select a 
            // KeyConfiguration
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Configuration Files|*.config";
            dlg.Title = "Select a Configuration File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                artPad.reconfigure(dlg.FileName);
            }
        }

        void toolStripAsMenuItemSaveAs_Click(object sender, System.EventArgs e) {
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

        void toolStripMenuItemEdit_Click(object sender, System.EventArgs e) {
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

        void toolStripMenuItemDeleteRow_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.deleteRow(keyDef.Row);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddRowBefore_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertRowBefore(keyDef.Row);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddRowAfter_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertRowAfter(keyDef.Row);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemDeleteCol_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.deleteCol(keyDef.Col);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddColBefore_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertColBefore(keyDef.Col);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddColAfter_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertColAfter(keyDef.Col);
            config.setSizeForKeySize(Width, Height);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemSort_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.sort();
            artPad.reconfigure(config);
        }

        void toolStripMenuItemCreateNew_click(object sender, System.EventArgs e) {
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

        void toolStripMenuItemSetKeySize_click(object sender, System.EventArgs e) {
            NumericEntry2Dialog dlg = new NumericEntry2Dialog();
            dlg.Text = "Key Size";
            dlg.Label1.Text = "Width";
            dlg.Label2.Text = "Height";
            dlg.NumericUpDown1.Value = Width;
            dlg.NumericUpDown2.Value = Height;
            if (dlg.ShowDialog() == DialogResult.OK) {
                ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
                Configuration config = artPad.Config;
                config.setSizeForKeySize((int)dlg.NumericUpDown1.Value,
                    (int)dlg.NumericUpDown2.Value);
                artPad.reconfigure(config);
            }
        }

        void toolStripMenuItemHoldKeysUp_click(object sender, System.EventArgs e) {
            try {
                ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
                Configuration config = artPad.Config;
                Tools.sendUpEventsForPressedKeys(config.KeyDefs);
                artPad.reconfigure(config);
            } catch (System.Exception ex) {
                Utils.excMsg("Error sending key up events", ex);
            }
        }

        void toolStripMenuItemCopyKey_click(object sender, System.EventArgs e) {
            try {
                string json =
                    JsonConvert.SerializeObject(keyDef, Formatting.Indented);
                Clipboard.SetText(json);
            } catch (System.Exception ex) {
                Utils.excMsg("Error sending key up events", ex);
            }
        }

        void toolStripMenuItemPasteKey_click(object sender, System.EventArgs e) {
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

        void toolStripMenuItemOverview_click(object sender, System.EventArgs e) {
            // Create, show, or set visible the overviewDialog as appropriate
            if (overviewDlg == null) {
                overviewDlg = new ScrolledHTMLDialog();
                overviewDlg.Show();
            } else {
                overviewDlg.Visible = true;
            }
        }

        void toolStripMenuItemAbout_click(object sender, System.EventArgs e) {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog();
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            // Use this for showing the context menu because OnClick
            // apparently does not get right mouse events
#if DEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseUp ("
                + keyDef.Row + "," + keyDef.Col + ")");
#endif
            // See if it is a right click
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right) {
                // Show the context menu
                contextMenuStrip.Show(this, me.X, me.Y);
                return;
            }
            base.OnMouseUp(e);
        }

        protected override void OnMouseEnter(System.EventArgs e) {
#if DEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseEnter ("
                + keyDef.Row + "," + keyDef.Col + ")");
#endif
            // Save the foreground window here
            Tools.saveForegroundWindow();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
#if DEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseLeave ("
                + keyDef.Row + "," + keyDef.Col + ")");
#endif
        }

        protected override void OnClick(System.EventArgs e) {
#if DEBUG && false
            Tools.debugForegroundWindows("KeyButton.OnClick");
#endif
            Tools.setForegroundWindowFromSaved();
#if DEBUG && false
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
            // Send the KeyString
            if (!FindForm().Equals(Tools.HForegroundWindow)) {
                SendKeys.Send(keyDef.KeyString);
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
#if DEBUG && false
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
            if (keyDef.Pressed) {
                keyDef.Pressed = false;
                sim.Keyboard.KeyUp(keyCode);
                // Use this instead of 
                // BackColor = Color.FromKnownColor(KnownColor.Control);
                UseVisualStyleBackColor = true;
            } else {
                sim.Keyboard.KeyDown(keyCode);
                keyDef.Pressed = true;
                BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {

        }
    }
}
