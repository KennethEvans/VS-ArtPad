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
            Tools.debugForegroundWindows("KeyButton.OnClick (After));
            debug.print("KeyButton.OnClick (After): Sending: " + keyConfig.KeyString);
#endif
            // Send theKeyString
            if (!FindForm().Equals(Tools.HForegroundWindow)) {
                SendKeys.Send(keyConfig.KeyString);
            }
        }
    }
}
