using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace ArtPad {
    public partial class ArtPadForm : Form {
        public ArtPadForm() {
            InitializeComponent();
        }

        protected override void OnLoad(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLoad");
#endif
            List<KeyConfig> keys = Tools.TestKeyConfigs;
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

        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }

        protected override void OnHandleCreated(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnHandleCreated (Before)");
#endif
            base.OnHandleCreated(e);
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnHandleCreated (After)");
#endif
        }

        protected override void OnBindingContextChanged(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnBindingContextChanged");
#endif
            base.OnBindingContextChanged(e);
        }

        protected override void OnActivated(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnActivated (Before)");
#endif
            base.OnActivated(e);
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnActivated (After)");
#endif
        }

        protected override void OnVisibleChanged(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnVisibleChanged");
#endif
            base.OnVisibleChanged(e);
        }

        protected override void OnShown(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnShown");
#endif
            base.OnShown(e);
        }

        protected override void OnGotFocus(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnGotFocus");
#endif
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(System.EventArgs e) {
            base.OnLostFocus(e);
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLostFocus");
#endif
        }

        protected override void OnLocationChanged(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLocationChanged");
#endif
            base.OnLocationChanged(e);
        }

        protected override void OnResizeEnd(System.EventArgs e) {
            base.OnResizeEnd(e);
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnResizeEnd (Before)");
#endif
            Tools.setForegroundWindowFromSaved();
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnResizeEnd (After)");
#endif
        }


        protected override void OnMouseEnter(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnMouseEnter");
#endif
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnMouseLeave");
#endif
        }

        protected override void OnMouseMove(MouseEventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnMouseMove");
#endif
        }

        private void ArtPadForm_Load(object sender, EventArgs e) {

        }
    }
}
