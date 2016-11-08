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
    public partial class ArtPadForm : Form {
        public ArtPadForm() {
            InitializeComponent();
        }

        protected override void OnLoad(System.EventArgs e) {
            List<KeyConfig> keys = Constants.TestKeyConfigs;
            int rows = -1;
            int cols = -1;

            // Get the table size
            foreach (KeyConfig key in keys) {
                if (key.COL > cols) cols = key.COL;
                if (key.ROW > rows) rows = key.ROW;
            }
            rows += 1;
            cols += 1;

            // Reset the rows and columns in the table
            this.tableLayoutPanel.RowCount = rows;
            this.tableLayoutPanel.ColumnCount = cols;
            this.tableLayoutPanel.RowStyles.Clear();
            this.tableLayoutPanel.ColumnStyles.Clear();
            float rowPercent = 100.0F / rows;
            float colPercent = 100.0F / cols;
            for (int row = 0; row < rows; row++) {
                this.tableLayoutPanel.RowStyles.
                    Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, rowPercent));
            }
            for (int col = 0; col < cols; col++) {
                this.tableLayoutPanel.ColumnStyles.
                            Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,
                            colPercent));
            }

            // Set the keys into the table
            KeyButton keyButton;
            foreach (KeyConfig key in keys) {
                keyButton = new KeyButton(key);
                keyButton.Text = key.Name;
                keyButton.Dock = DockStyle.Fill;
                keyButton.Margin = new Padding(0);  // Default is 3
                this.tableLayoutPanel.Controls.Add(keyButton, key.COL, key.ROW);
            }
        }

        private void ArtPadForm_Load(object sender, EventArgs e) {

        }
    }
}
