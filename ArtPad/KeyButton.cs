using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace ArtPad {
    public partial class KeyButton : Button {
        private string LF = System.Environment.NewLine;
        private KeyConfig key;

        public KeyButton(KeyConfig key) {
            this.key = key;
            InitializeComponent();

            // Should have been able to do this in the designer
            this.toolStripLoadMenuItem.Click +=
                new System.EventHandler(this.toolStripLoadMenuItem_Click);
        }

        void toolStripLoadMenuItem_Click(object sender, System.EventArgs e) {
            int size = Application.OpenForms.Count;
            ArtPadForm mainForm = (ArtPadForm)FindForm().FindForm();

            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Configuration Files|*.config";
            ofd.Title = "Select a Configuration File";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                mainForm.reconfigure(ofd.FileName);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            // Use this for showing the context menu because OnClick
            // apparently does not get right mouse events
#if DEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseUp ("
                + key.ROW + "," + key.COL + ")");
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
                + key.ROW + "," + key.COL + ")");
#endif
            // Save the foreground window here
            Tools.saveForegroundWindow();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
#if DEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseLeave ("
                + key.ROW + "," + key.COL + ")");
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
            switch (key.Type) {
                case KeyConfig.KeyType.NORMAL:
                    handleNormalKey(e);
                    break;
                case KeyConfig.KeyType.COMMAND:
                    handleCommandKey(e);
                    break;
                case KeyConfig.KeyType.HOLD:
                    handleHoldKey(e);
                    break;
                default:
                    Utils.errMsg("Unhandled key type: " + key.Type);
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
                SendKeys.Send(key.KeyString);
            }
        }

        /// <summary>
        /// Handles a COMMAND key
        /// </summary>
        /// <param name="e"></param>
        protected void handleCommandKey(System.EventArgs e) {
            // Send the KeyString as a command
            var process = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = key.KeyString
                }
            };
            process.Start();
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
                keyCode = Tools.getKeyCode(key);
            } catch (System.ArgumentException) {
                Utils.errMsg("Cannot handle HOLD for " + key.KeyString
                    + LF + "Must be ^ (Ctrl), % (Alt), or + (Shift)");
                return;
            }

            var sim = new InputSimulator();
            if (key.Pressed) {
                key.Pressed = false;
                sim.Keyboard.KeyUp(keyCode);
                this.BackColor = Color.FromKnownColor(KnownColor.Control);
            } else {
                sim.Keyboard.KeyDown(keyCode);
                key.Pressed = true;
                this.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
        }

    }
}
