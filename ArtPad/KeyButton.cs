using System.Diagnostics;
using System.Windows.Forms;

namespace ArtPad {
    public partial class KeyButton : Button {
        private KeyConfig keyConfig;

        public KeyButton(KeyConfig keyConfig) {
            this.keyConfig = keyConfig;
            InitializeComponent();
        }

        protected override void OnMouseEnter(System.EventArgs e) {
#if DEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseEnter ("
                + keyConfig.ROW + "," + keyConfig.COL + ")");
#endif
            Tools.saveForegroundWindow();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
#if DEBUG && true
            Tools.debugForegroundWindows("KeyButton.OnMouseLeave ("
                + keyConfig.ROW + "," + keyConfig.COL + ")");
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
            switch (keyConfig.Type) {
                case KeyConfig.KeyType.NORMAL:
                    handleNormalKey(e);
                    break;
                case KeyConfig.KeyType.COMMAND:
                    handleCommandKey(e);
                    break;
                default:
                    Utils.errMsg("Unhandled key type: " + keyConfig.Type);
                    break;
            }
        }

        /// <summary>
        /// Handles a NORMAL key
        /// </summary>
        /// <param name="e"></param>
        protected void handleNormalKey(System.EventArgs e) {
            // Send the KeyString
            if (!FindForm().Equals(Tools.HForegroundWindow)) {
                SendKeys.Send(keyConfig.KeyString);
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
                    FileName = keyConfig.KeyString
                }
            };
            process.Start();
#if DEBUG && false
            Tools.debugForegroundWindows("handleCommandKey (After)");
#endif
        }
    }
}
