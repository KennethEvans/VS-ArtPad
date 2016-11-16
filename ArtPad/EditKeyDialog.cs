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
    public partial class EditKeyDialog : Form {
        private KeyButton button;
        private KeyConfig keyOrig;
        private ArtPadForm artPad;

        public EditKeyDialog(KeyConfig key, KeyButton button, ArtPadForm artPad) {
            InitializeComponent();
            keyOrig = new KeyConfig(key);
            this.button = button;
            this.artPad = artPad;
            populateControls(key);
        }

        public void populateControls(KeyConfig key) {
            this.labelRowCol.Text = "Edit Key Button ("
                + key.Row + "," + key.Col + ")";
            this.textBoxName.Text = key.Name;
            this.textBoxKeyString.Text = key.KeyString;
            this.comboBoxType.SelectedIndex = (int)key.Type;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            // Just hide rather than close if the user did it
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Visible=false;
            }
        }

        private void editKeyTableLayoutPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void copyButton_click(object sender, EventArgs e) {

        }

        private void pasteButton_click(object sender, EventArgs e) {

        }

        private void deleteKeyButton_click(object sender, MouseEventArgs e) {

        }

        private void resetKeyButton_click(object sender, MouseEventArgs e) {
            populateControls(keyOrig);
        }

        private void setKeyButton_click(object sender, MouseEventArgs e) {
            string name = textBoxName.Text;
            string keyString = this.textBoxKeyString.Text;
            int sel = this.comboBoxType.SelectedIndex;
            KeyConfig.KeyType type = (KeyConfig.KeyType)sel;
            KeyConfig newKey = new KeyConfig(name, keyString, type,
                keyOrig.Row, keyOrig.Col);
            Configuration config = artPad.Config;
            int index = config.Keys.FindIndex(
                key => key.Row == newKey.Row && key.Col == newKey.Col);
            if (index == -1) {
                Utils.errMsg("Error finding key to set");
                return;
            }
            config.Keys[index] = new KeyConfig(newKey);
            artPad.reconfigure(config);
            this.Visible = false;
        }

        private void resetAllButton_click(object sender, MouseEventArgs e) {

        }

        private void setAllButton_click(object sender, MouseEventArgs e) {

        }

        private void saveAllButton_click(object sender, MouseEventArgs e) {

        }

        private void dismissButton_click(object sender, MouseEventArgs e) {
            Visible = false;
        }

    }
}
