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
        private KeyConfig keyOrig;

        public EditKeyDialog(KeyConfig key) {
            InitializeComponent();
            keyOrig = new KeyConfig(key);
            this.labelRowCol.Text = "Edit Key Button ("
                + key.Row + "," + key.Col + ")";
            this.textBoxName.Text = key.Name;
            this.textBoxKeyString.Text = key.KeyString;
            this.comboBoxType.SelectedIndex = (int)key.Type;
        }

        private void editKeyTableLayoutPanel_Paint(object sender, PaintEventArgs e) {

        }
    }
}
