#define CHECK_EVENTS
//#undef DEBUG

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ArtPad {
    public partial class ArtPadForm : Form {
        private string LF = Utils.LF;
        private int defaultKeySize = 50;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private Configuration config = new Configuration();
        private List<KeyDef> keyDefs = Tools.TestKeyDefs;

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public ArtPadForm() {
            Config.KeyDefs = Tools.TestKeyDefs;
            Config.setSizeForKeySize(defaultKeySize, defaultKeySize);
            InitializeComponent();
        }

        /// <summary>
        /// Constructor to use command-line args.
        /// </summary>
        /// <param name="args"></param>
        public ArtPadForm(string[] args) {
            if (args.Length > 0) {
                Configuration newConfig = Configuration.readConfig(args[0]);
                if (newConfig != null) {
                    Config = newConfig;
                    keyDefs = Config.KeyDefs;
                } else {
                    Utils.errMsg("Error reading configuration");
                }
            } else {
                Config.KeyDefs = Tools.TestKeyDefs;
                Config.setSizeForKeySize(defaultKeySize, defaultKeySize);
            }
            InitializeComponent();
#if DEBUG
            Configuration.writeConfig(Config, @"c:\scratch\ArtPad-startup.config");
#endif
        }

        /// <summary>
        /// Resets the key configuration.
        /// </summary>
        /// <param name="newConfig"></param>
        public void reconfigure(Configuration newConfig) {
            if (newConfig == null) {
                Utils.errMsg("New configuration is null");
                return;
            }
            if (newConfig.KeyDefs.Count == 0) {
                DialogResult res = MessageBox.Show(
                    "There are no keys in the specified configuration"
                    + LF + "Ok to continue?",
                    "Warning", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes) {
                    return;
                }
            }
            Config = newConfig;
            keyDefs = Config.KeyDefs;
            createTable();
            Invalidate();
        }

        /// <summary>
        /// Resets the configuration using the configuration from the
        /// given file.
        /// </summary>
        /// <param name="fileName"></param>
        public void reconfigure(string fileName) {
            Configuration newConfig = Configuration.readConfig(fileName);
            if (newConfig.KeyDefs.Count == 0) {
                DialogResult res = MessageBox.Show("There are no keys in:"
                    + LF + fileName
                    + LF + "The contents may be wrong."
                    + LF + LF + "Ok to continue?",
                    "Warning", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes) {
                    return;
                }
            }
            reconfigure(newConfig);
        }

        /// <summary>
        /// Clears the current TableLayoutPanel, removes it from the controls,
        /// adds new KeyButtons, then adds the TableLayoutPanel to the Controls.
        /// It resizes the client area to fit the size in the Configuration.
        /// </summary>
        protected void createTable() {
            if (keyDefs == null) {
                Utils.errMsg("No keys are defined");
                return;
            }

            // Get the table size
            int rows = Config.Rows;
            int cols = Config.Cols;
            Debug.Print("createTable: rows=" + rows + " cols=" + cols);

            // Remove any existing tableLayoutPanel
            if (this.Controls.Contains(tableLayoutPanel)) {
                tableLayoutPanel.Controls.Clear();
                tableLayoutPanel.RowStyles.Clear();
                tableLayoutPanel.ColumnStyles.Clear();
                Controls.Remove(tableLayoutPanel);
                tableLayoutPanel.Dispose();
            }

            ClientSize = new Size(Config.Size.Width,
                Config.Size.Height);

            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = cols;
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.TabIndex = 0;
            tableLayoutPanel.Margin = new Padding(0);
#if false
            Debug.Print("tableLayoutPanel: margin=" + tableLayoutPanel.Margin);
            Debug.Print("tableLayoutPanel: padding=" + tableLayoutPanel.Padding);
#endif
            // Set the rows and columns in the table
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.ColumnCount = cols;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Dock = DockStyle.Fill;
            float rowPercent = 100.0F / rows;
            float colPercent = 100.0F / cols;
            for (int row = 0; row < rows; row++) {
                this.tableLayoutPanel.RowStyles.
                    Add(new RowStyle(SizeType.Percent, rowPercent));
            }
            for (int col = 0; col < cols; col++) {
                tableLayoutPanel.ColumnStyles.
                    Add(new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, colPercent));
            }

            // Set the key definitions into the table
            KeyButton keyButton;
            int buttonWidth = Config.Size.Width / Config.Cols;
            if (buttonWidth <= 0) buttonWidth = 50;
            int buttonHeight = Config.Size.Height / Config.Rows;
            if (buttonHeight <= 0) buttonHeight = 50;

            foreach (KeyDef keyDef in keyDefs) {
                keyButton = new KeyButton(keyDef);
                if (keyDef.Type == KeyDef.KeyType.UNUSED) {
                    keyButton.Text = "";
                    keyButton.BackColor =
                        Color.FromKnownColor(KnownColor.ControlLight);
                } else {
                    keyButton.Text = keyDef.Name;
                }
                keyButton.Dock = DockStyle.Fill;
                keyButton.Margin = new Padding(0);
                keyButton.Width = buttonWidth;
                keyButton.Height = buttonHeight;
                keyButton.AutoSize = true;
                keyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                tableLayoutPanel.Controls.Add(keyButton, keyDef.Col, keyDef.Row);
#if False
                Debug.Print("keyButton: AutoSize=" + keyButton.AutoSize);
                Debug.Print("keyButton: MinimumSize=" + keyButton.MinimumSize);
                Debug.Print("keyButton: AutoSizeMode=" + keyButton.AutoSizeMode);
#endif
            }
            Controls.Add(tableLayoutPanel);
        }

        protected override void OnLoad(System.EventArgs e) {
#if DEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLoad");
#endif
            reconfigure(Config);
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
            if (keyDefs != null) {
                Tools.sendUpEventsForPressedKeys(keyDefs);
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
#region Check events
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
#endregion Check events

    }
}
