using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ArtPad {
    public partial class EditKeyDialog : Form {
        private KeyButton button;
        private KeyDef keyDefOrig;
        private ArtPadForm artPad;

        public EditKeyDialog(KeyDef keyDef, KeyButton button, ArtPadForm artPad) {
            InitializeComponent();
            resetContents(keyDef, button, artPad);
        }

        public void resetContents(KeyDef keyDef, KeyButton button, ArtPadForm artPad) {
            keyDefOrig = new KeyDef(keyDef);
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

        public KeyDef keyDefFromDialog() {
            string name = textBoxName.Text;
            string keyString = this.textBoxKeyString.Text;
            int sel = this.comboBoxType.SelectedIndex;
            KeyDef.KeyType type = (KeyDef.KeyType)sel;
            KeyDef newKeyDef = new KeyDef(name, keyString, type,
                keyDefOrig.Row, keyDefOrig.Col);
            return newKeyDef;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            // Just hide rather than close if the user did it
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void editKeyTableLayoutPanel_Paint(object sender, PaintEventArgs e) {

        }

        /// <summary>
        /// Set the current values from the dialog into a Json string and sets
        /// it in the Clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyButton_click(object sender, MouseEventArgs e) {
            KeyDef newKeyDef = keyDefFromDialog();
            string json =
                JsonConvert.SerializeObject(newKeyDef, Formatting.Indented);
            Clipboard.SetText(json);
        }

        /// <summary>
        /// Replaces the current values from a Json string in the Clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pasteButton_click(object sender, MouseEventArgs e) {
            IDataObject ClipData = Clipboard.GetDataObject();
            if (ClipData.GetDataPresent(DataFormats.Text)) {
                string json = Clipboard.GetData(DataFormats.Text).ToString();
                KeyDef newKeyDef;
                try {
                    newKeyDef = JsonConvert.DeserializeObject<KeyDef>(json);
                } catch (Exception ex) {
                    Utils.excMsg(
                        "Error converting clibboard contents to a "
                        + "key definition", ex);
                    return;
                }
                populateControls(newKeyDef);
            }

        }


        private void resetButton_click(object sender, MouseEventArgs e) {
            populateControls(keyDefOrig);
        }

        private void deleteKeyButton_click(object sender, MouseEventArgs e) {

        }

        private void setKeyButton_click(object sender, MouseEventArgs e) {
            KeyDef newKeyDef = keyDefFromDialog();
            Configuration config = artPad.Config;
            int index = config.KeyDefs.FindIndex(
                keyDef => keyDef.Row == newKeyDef.Row && keyDef.Col == newKeyDef.Col);
            if (index == -1) {
                Utils.errMsg("Error finding key definition to set");
                return;
            }
            config.KeyDefs[index] = newKeyDef;
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
