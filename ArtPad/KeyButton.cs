using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace ArtPad {
    public partial class KeyButton : Button {
        private string LF = System.Environment.NewLine;
        private static EditKeyDialog editKeyDlg;
        private KeyDef keyDef;

        public KeyButton(KeyDef key) {
            this.keyDef = key;
            InitializeComponent();

            // Should have been able to do this in the designer
            this.toolStripMenuItemLoad.Click +=
                new System.EventHandler(this.toolStripMenuItemLoad_Click);
            this.toolStripMenuItemSaveAs.Click +=
                new System.EventHandler(this.toolStripAsMenuItemSaveAs_Click);
            this.toolStripMenuItemEditKey.Click +=
                new System.EventHandler(this.toolStripMenuItemEdit_Click);
            this.toolStripMenuItemDeleteRow.Click +=
                new System.EventHandler(this.toolStripMenuItemDeleteRow_click);
            this.toolStripMenuItemAddRowBefore.Click +=
                new System.EventHandler(this.toolStripMenuItemAddRowBefore_click);
            this.toolStripMenuItemAddRowAfter.Click +=
                new System.EventHandler(this.toolStripMenuItemAddRowAfter_click);
            this.toolStripMenuItemDeleteCol.Click +=
                new System.EventHandler(this.toolStripMenuItemDeleteCol_click);
            this.toolStripMenuItemAddColBefore.Click +=
                new System.EventHandler(this.toolStripMenuItemAddColBefore_click);
            this.toolStripMenuItemAddColAfter.Click +=
                new System.EventHandler(this.toolStripMenuItemAddColAfter_click);
            this.toolStripMenuItemSort.Click +=
                new System.EventHandler(this.toolStripMenuItemSort_click);
            this.toolStripMenuItemCreateNew.Click +=
                new System.EventHandler(this.toolStripMenuItemCreateNew_click);
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
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Configuration Files|*.config";
            dlg.Title = "Select a Configuration File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Configuration.writeConfig(artPad.Config, dlg.FileName);
            }
        }

        void toolStripMenuItemEdit_Click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            // Create, show, or visiblethe EditKeyDialog as appropriate
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
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddRowBefore_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertRowBefore(keyDef.Row);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddRowAfter_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertRowAfter(keyDef.Row);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemDeleteCol_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.deleteCol(keyDef.Col);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddColBefore_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertColBefore(keyDef.Col);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemAddColAfter_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.insertColAfter(keyDef.Col);
            artPad.reconfigure(config);
        }

        void toolStripMenuItemSort_click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            Configuration config = artPad.Config;
            config.sort();
            artPad.reconfigure(config);
        }

        void toolStripMenuItemCreateNew_click(object sender, System.EventArgs e) {
            //ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            //Configuration config = Configuration.generateNewConfiguration();
            //artPad.reconfigure(config);
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
