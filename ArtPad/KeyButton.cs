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
                new System.EventHandler(this.toolStripLoadMenuItem_Click);

            this.toolStripMenuItemSaveAs.Click +=
                new System.EventHandler(this.toolStripSaveAsMenuItem_Click);

            this.toolStripMenuItemEdit.Click +=
                new System.EventHandler(this.toolStripEditMenuItem_Click);
        }

        void toolStripLoadMenuItem_Click(object sender, System.EventArgs e) {

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

        void toolStripSaveAsMenuItem_Click(object sender, System.EventArgs e) {
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

        void toolStripEditMenuItem_Click(object sender, System.EventArgs e) {
            ArtPadForm artPad = (ArtPadForm)FindForm().FindForm();
            // Create, show, or visiblethe EditKeyDialog as appropriate
            if (editKeyDlg == null) {
                editKeyDlg = new EditKeyDialog(keyDef, this, artPad);
                editKeyDlg.Show();
            }
            if (editKeyDlg.Visible) {
                editKeyDlg.populateControls(keyDef);
            } else {
                editKeyDlg.Visible = true;
            }
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
