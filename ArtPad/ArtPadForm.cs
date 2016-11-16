#define CHECK_EVENTS
#undef DEBUG

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace ArtPad {
    public partial class ArtPadForm : Form {
        private string LF = Utils.LF;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private Configuration config = new Configuration();
        private List<KeyDef> keysDefs = Tools.TestKeyDefs;

        public ArtPadForm() {
            Config.KeyDefs = Tools.TestKeyDefs;
            InitializeComponent();
        }

        public ArtPadForm(string[] args) {
            if (args.Length > 0) {
                Configuration newConfig = Configuration.readConfig(args[0]);
                if (newConfig != null) {
                    Config = newConfig;
                    keysDefs = Config.KeyDefs;
                } else {
                    Utils.errMsg("Error reading configuration");
                }
            } else {
                Config.KeyDefs = Tools.TestKeyDefs;
            }
            InitializeComponent();
#if DEBUG
            saveConfiguration(@"c:\scratch\ArtPad-startup.config");
#endif
        }

        /// <summary>
        /// Resets the key configuration.
        /// </summary>
        /// <param name="newConfig"></param>
        public void reconfigure(Configuration newConfig) {
            if (newConfig != null) {
                Config = newConfig;
                keysDefs = Config.KeyDefs;
            } else {
                Utils.errMsg("Error reading configuration");
            }
#if DEBUG
            Debug.Print("reconfigure(2): config: nKeys=" + config.Keys.Count
                + " Size=" + config.Size);
#endif
#if DEBUG
            saveConfiguration(@"c:\scratch\ArtPad-reconfigure.config");
#endif
            createTable();
        }

        /// <summary>
        /// Resets the configuration using the configuration from the
        /// given file.
        /// </summary>
        /// <param name="fileName"></param>
        public void reconfigure(string fileName) {
            Configuration newConfig = Configuration.readConfig(fileName);
            Debug.Print("reconfigure(1): config: nKeys=" + Config.KeyDefs.Count
                + " Size=" + Config.Size);
            Debug.Print("reconfigure(1): newConfig: nKeys=" + newConfig.KeyDefs.Count
                + " Size=" + Config.Size);
            reconfigure(newConfig);
        }

        protected void createTable() {
            if (keysDefs == null) {
                Utils.errMsg("No keys are defined");
                return;
            }

            // Get the table size
            int rows = -1;
            int cols = -1;
            foreach (KeyDef keyDef in keysDefs) {
                if (keyDef.Col > cols) cols = keyDef.Col;
                if (keyDef.Row > rows) rows = keyDef.Row;
            }
            rows += 1;
            cols += 1;
            Debug.Print("createTable: rows=" + rows + " cols=" + cols);

            // Remove any existing tableLayoutPanel
            if (this.Controls.Contains(tableLayoutPanel)) {
                tableLayoutPanel.Controls.Clear();
                tableLayoutPanel.RowStyles.Clear();
                tableLayoutPanel.ColumnStyles.Clear();
                this.Controls.Remove(tableLayoutPanel);
                tableLayoutPanel.Dispose();
            }

            this.ClientSize =
            new System.Drawing.Size(Config.Size.Width, Config.Size.Width);

            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = cols;
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = rows;
            this.tableLayoutPanel.TabIndex = 0;

            // Set the rows and columns in the table
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

            // Set the key definitions into the table
            KeyButton keyButton;
            foreach (KeyDef keyDef in keysDefs) {
                keyButton = new KeyButton(keyDef);
                if (keyDef.Type == KeyDef.KeyType.UNUSED) {
                    keyButton.Text = "";
                    keyButton.BackColor =
                        Color.FromKnownColor(KnownColor.ControlLight);
                } else {
                    keyButton.Text = keyDef.Name;
                }
                keyButton.Dock = DockStyle.Fill;
                keyButton.Margin = new Padding(0);  // Default is 3
                tableLayoutPanel.Controls.Add(keyButton, keyDef.Col, keyDef.Row);
            }

            this.Controls.Add(this.tableLayoutPanel);
        }

        protected override void OnLoad(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLoad");
#endif
            createTable();
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

        public Configuration Config
        {
            get
            {
                return config;
            }

            set
            {
                config = value;
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
            if (keysDefs != null) {
                Tools.sendUpEventsForPressedKeys(keysDefs);
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
#if DEBUG && false
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
