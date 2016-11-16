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
        private KeyDef keyOrig;
        private ArtPadForm artPad;

        public EditKeyDialog(KeyDef keyDef, KeyButton button, ArtPadForm artPad) {
            InitializeComponent();
            keyOrig = new KeyDef(keyDef);
            this.button = button;
            this.artPad = artPad;
            populateControls(keyDef);
        }

        public void populateControls(KeyDef keyDef) {
            this.labelRowCol.Text = "Edit Key Button ("
                + keyDef.Row + "," + keyDef.Col + ")";
            this.textBoxName.Text = keyDef.Name;
            this.textBoxKeyString.Text = keyDef.KeyString;
            this.comboBoxType.SelectedIndex = (int)keyDef.Type;
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
            KeyDef.KeyType type = (KeyDef.KeyType)sel;
            KeyDef newKey = new KeyDef(name, keyString, type,
                keyOrig.Row, keyOrig.Col);
            Configuration config = artPad.Config;
            int index = config.KeyDefs.FindIndex(
                keyDef => keyDef.Row == newKey.Row && keyDef.Col == newKey.Col);
            if (index == -1) {
                Utils.errMsg("Error finding key definition to set");
                return;
            }
            config.KeyDefs[index] = new KeyDef(newKey);
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
