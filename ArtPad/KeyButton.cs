using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ArtPad {
    public partial class KeyButton : Button {
        private KeyConfig keyConfig;

        public KeyButton(KeyConfig keyConfig) {
            this.keyConfig = keyConfig;
            InitializeComponent();
        }

        protected override void OnMouseEnter(System.EventArgs e) {
            IntPtr hWnd = Constants.getForegroundWindow();
            Constants.hForegroundWindow = hWnd;
            Debug.Print("OnMouseEnter: " + Constants.getWindowTitle(hWnd));
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
            IntPtr hWnd = Constants.getForegroundWindow();
            Debug.Print("OnMouseLeave: " + Constants.getWindowTitle(hWnd));
        }

        protected override void OnClick(System.EventArgs e) {
            string title = Constants.getActiveWindowTitle();
            string saveTitle = Constants.getWindowTitle(Constants.hForegroundWindow);
            Debug.Print("OnClick: " + title);
            Debug.Print("OnClick: Saved: " + saveTitle);
            if (Constants.hForegroundWindow != IntPtr.Zero) {
                Constants.SetForegroundWindow(Constants.hForegroundWindow);
            }
            title = Constants.getActiveWindowTitle();
            Debug.Print("OnClick: After: " + title);

            if (!FindForm().Equals(Constants.hForegroundWindow)) {
                SendKeys.Send(keyConfig.KeyString);
            }

            //string msg;
            //if (keyConfig == null) {
            //    msg = this.Text;
            //} else {
            //    msg = keyConfig.KeyString;
            //}
            //msg += Environment.NewLine + "Title: " + title
            //        + Environment.NewLine + "SaveTitle: " + saveTitle;
            //MessageBox.Show(msg, "KeyButton",
            //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
