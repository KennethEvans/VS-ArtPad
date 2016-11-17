using System;
using System.Windows.Forms;

namespace ArtPad {
    public partial class NumericEntry2Dialog : Form {

        public NumericEntry2Dialog() {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
