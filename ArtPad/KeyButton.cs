using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtPad {
    public partial class KeyButton : Button {
        private KeyConfig keyConfig;

        public KeyButton(KeyConfig keyConfig) {
            this.keyConfig = keyConfig;
            InitializeComponent();
        }

        protected override void OnMouseEnter(System.EventArgs e) {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
        }

        protected override void OnClick(System.EventArgs e) {
            if (keyConfig == null) {
                MessageBox.Show("OnClick: " + this.Text, "KeyButton",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            } else {
                MessageBox.Show(keyConfig.KeyString, "KeyButton",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
