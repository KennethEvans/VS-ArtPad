using KEUtils.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtPad {
    public partial class AppearanceDialog : Form {
        public AppearanceDialog() {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            string errMsg = null;
            string fgColorString = TextBoxFg.Text;
            string bgColorString = TextBoxBg.Text;
            if (fgColorString.Length > 0 &&
                 !Configuration.isValidColorString(fgColorString)) {
                errMsg = "Invalid FG Color (" + fgColorString + ")";
            }
            if (bgColorString.Length > 0 &&
                 !Configuration.isValidColorString(bgColorString)) {
                if (errMsg == null) {
                    errMsg = "Invalid BG Color (" + fgColorString + ")";
                } else {
                    errMsg += Environment.NewLine
                        + "Invalid BG Color (" + bgColorString + ")";
                }
            }
            if (errMsg != null) {
                errMsg += Environment.NewLine + "Must be blank or of the form #RRGGBB"
                    + Environment.NewLine + "where R, G, and B are valid Hex digits";
                Utils.errMsg(errMsg);
            } else { 
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonFg_click(object sender, EventArgs e) {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                Color color = dlg.Color;
                TextBoxFg.Text = Configuration.colorToHexString(color);
            }
        }

        private void buttonBg_click(object sender, EventArgs e) {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                Color color = dlg.Color;
                TextBoxBg.Text = Configuration.colorToHexString(color);
            }
        }
    }
}
