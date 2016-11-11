#define CHECK_EVENTS

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsInput;
using WindowsInput.Native;

namespace ArtPad {
    public partial class ArtPadForm : Form {
        private string LF = System.Environment.NewLine;

        private List<KeyConfig> keys = Tools.TestKeyConfigs;

        public ArtPadForm() {
            InitializeComponent();
        }

        protected void populateTable() {
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();

            if (keys == null) {
                Utils.errMsg("No keys are defined");
                return;
            }

            // Get the table size
            int rows = -1;
            int cols = -1;
            foreach (KeyConfig key in keys) {
                if (key.COL > cols) cols = key.COL;
                if (key.ROW > rows) rows = key.ROW;
            }
            rows += 1;
            cols += 1;

            // Reset the rows and columns in the table
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.ColumnCount = cols;
            float rowPercent = 100.0F / rows;
            float colPercent = 100.0F / cols;
            for (int row = 0; row < rows; row++) {
                this.tableLayoutPanel.RowStyles.
             Add(new RowStyle(SizeType.Percent, rowPercent));
            }
            for (int col = 0; col < cols; col++) {
                tableLayoutPanel.ColumnStyles.
                            Add(new System.Windows.Forms.ColumnStyle(
                                System.Windows.Forms.SizeType.Percent,
                                colPercent));
            }

            // Set the keys into the table
            KeyButton keyButton;
            foreach (KeyConfig key in keys) {
                keyButton = new KeyButton(key);
                keyButton.Text = key.Name;
                keyButton.Dock = DockStyle.Fill;
                keyButton.Margin = new Padding(0);  // Default is 3
                tableLayoutPanel.Controls.Add(keyButton, key.COL, key.ROW);
            }
        }

        protected override void OnLoad(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLoad");
#endif
            populateTable();
        }

        /// <summary>
        /// ShowWithoutActivation is readonly and  needs to be overwritten to
        /// keep the Form from being activated when it is shown.
        /// </summary>
        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
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

        protected override void OnFormClosing(FormClosingEventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnFormClosing");
#endif
            // Send up events for any pressed keys
            if (keys != null) { }
            foreach (KeyConfig key in keys) {
                if (key.Type == KeyConfig.KeyType.HOLD && key.Pressed == true) {
                    key.Pressed = false;

                    VirtualKeyCode keyCode;
                    if (key.KeyString.Equals("^")) { // Ctrl
                        keyCode = VirtualKeyCode.CONTROL;
                    } else if (key.KeyString.Equals("%")) { // Alt
                        keyCode = VirtualKeyCode.MENU;
                    } else if (key.KeyString.Equals("+")) { // Shift
                        keyCode = VirtualKeyCode.SHIFT;
                    } else {
                        Utils.errMsg("Cannot handle HOLD for " + key.KeyString
                            + LF + "Must be ^ (Ctrl), % (Alt), or + (Shift)");
                        return;
                    }
                    var sim = new InputSimulator();
                    sim.Keyboard.KeyUp(keyCode);
                }
            }

            base.OnFormClosing(e);
        }

        private void ArtPadForm_Load(object sender, EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm_Load");
#endif
        }

        // Define debugging for determining when events are called
        // and the state of the foreground window
#if CHECK_EVENTS

        protected override void OnMouseEnter(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnMouseEnter");
#endif
            base.OnMouseEnter(e);
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

#endif //CHECK_EVENTS

    }
}
