//#define CHECK_EVENTS
//#undef DODEBUG

using KEUtils.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ArtPad {
    public partial class ArtPadForm : Form {
        private string LF = Environment.NewLine;
        private int defaultKeySize = 50;
        private string lastConfigFile;
        private static Point defaultLocation = new Point(50, 50);
        private string defaultFontName;
        private float defaultFontSize = 0;
        private FontStyle defaultFontStyle = FontStyle.Regular;
        public bool moving = false;
        public bool sizing  = false;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private Configuration config = new Configuration();
        private List<KeyDef> keyDefs = Tools.TestKeyDefs;

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public ArtPadForm() {
            initialize(null);
        }

        /// <summary>
        /// Constructor to use command-line args.
        /// </summary>
        /// <param name="args"></param>
        public ArtPadForm(string[] args) {
            initialize(args);
        }

        /// <summary>
        /// Initialization (called by all constructors).
        /// </summary>
        /// <param name="args"></param>
        private void initialize(string[] args) {
            // Read persistent settings
            lastConfigFile = Properties.Settings.Default.LastConfigFile;

            if (args != null && args.Length > 0) {
                // First use the arguments if there are any
                Configuration newConfig = Configuration.readConfig(args[0]);
                if (newConfig != null) {
                    config = newConfig;
                    keyDefs = config.KeyDefs;
                    lastConfigFile = args[0];
                } else {
                    Utils.errMsg("Error reading configuration");
                }
            } else if (File.Exists(lastConfigFile)) {
                // Next use the last coinfiguration.
                Configuration newConfig =
                    Configuration.readConfig(lastConfigFile);
                if (newConfig != null) {
                    config = newConfig;
                    keyDefs = config.KeyDefs;
                } else {
                    Utils.errMsg("Error reading configuration");
                }
            } else {
                // Finally use the default configuration
                config = new Configuration();
                config.KeyDefs = Tools.TestKeyDefs;
                config.setSizeForKeySize(defaultKeySize, defaultKeySize);
            }

            // Set the location to the saved location
            // (will be modified in reconfigure)
            Point lastLocation = Properties.Settings.Default.LastLocation;
            if (lastLocation != null) {
                Location = lastLocation;
            }

            InitializeComponent();

            // Get the default font
            defaultFontName = this.Font.Name;
            defaultFontSize = this.Font.SizeInPoints;
            defaultFontStyle = this.Font.Style;
#if DODEBUG
            Tools.printModuleInfo();
            Configuration.writeConfig(config,
                @"c:\scratch\ArtPad-startup.config");
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

            // Set the title bar type
            if (newConfig.TitleBarType == 1) {
                ControlBox = false;
                FormBorderStyle = FormBorderStyle.None;
                Text = "";
            } else {
                ControlBox = true;
                FormBorderStyle = FormBorderStyle.Sizable;
                Text = "Art Pad";
            }

            Properties.Settings.Default.LastLocation = Location;

            config = newConfig;
            keyDefs = config.KeyDefs;
            moving = sizing = false;
            createTable();
            Invalidate();

            // Set the Location to the lastLocation
            Point lastLocation = Properties.Settings.Default.LastLocation;
            if (lastLocation == null) {
                lastLocation = defaultLocation;
            }
            Rectangle bounds = this.Bounds;
            Rectangle screenBounds = Screen.FromControl(this).Bounds;
            Debug.Print("LastLocation (Before) =" + lastLocation);
            Debug.Print("Bounds =" + bounds);
            Debug.Print("Screen =" + screenBounds);
            if (lastLocation.X < 0) {
                lastLocation.X = screenBounds.Left;
            }
            if (lastLocation.X > screenBounds.Right - Bounds.Width) {
                lastLocation.X = screenBounds.Right - Bounds.Width;
            }
            if (lastLocation.Y < 0) {
                lastLocation.Y = screenBounds.Top;
            }
            if (lastLocation.Y > screenBounds.Bottom - Bounds.Height) {
                lastLocation.Y = screenBounds.Bottom - Bounds.Height;
            }
            this.Location = lastLocation;
            Debug.Print("LastLocation (After) =" + lastLocation);
        }

        /// <summary>
        /// Resets the configuration using the configuration from the
        /// given file.
        /// </summary>
        /// <param name="fileName"></param>
        public void reconfigure(string fileName) {
            Configuration newConfig = Configuration.readConfig(fileName);
            // Handle possible bad values
            if (newConfig.TitleBarType != 1) {
                newConfig.TitleBarType = 0;
            }
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
            lastConfigFile = fileName;
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
            int rows = config.Rows;
            int cols = config.Cols;
            Debug.Print("createTable: rows=" + rows + " cols=" + cols);

            // Remove any existing tableLayoutPanel
            if (this.Controls.Contains(tableLayoutPanel)) {
                tableLayoutPanel.Controls.Clear();
                tableLayoutPanel.RowStyles.Clear();
                tableLayoutPanel.ColumnStyles.Clear();
                Controls.Remove(tableLayoutPanel);
                tableLayoutPanel.Dispose();
            }

            ClientSize = new Size(config.Size.Width,
                config.Size.Height);

            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = cols;
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.TabIndex = 0;
            tableLayoutPanel.Margin = new Padding(0);

            // Font
            string fontName = config.FontName;
            float fontSize = config.FontSize;
            FontStyle fontStyle = config.getFontStyle();
            Font font = null;
            if (fontSize <= 0) fontSize = defaultFontSize;
            if (config.FontName == null || config.FontName.Length <= 0) {
                fontName = defaultFontName;
                // If the name is invalid, then the FontStyle is invalid
                fontStyle = defaultFontStyle;
            }
            try {
                font = new Font(fontName, fontSize, fontStyle);
                tableLayoutPanel.Font = font;
                config.FontName = font.Name;
                config.FontSize = font.SizeInPoints;
                if (!font.Name.Equals(fontName) || !font.Size.Equals(config.FontSize)) {
                    Utils.errMsg("Error loading "
                        + fontName + " " + config.FontSize + " pt" + LF
                        + "Using "
                        + font.Name + " " + font.SizeInPoints + " pt");
                }
            } catch (Exception ex) {
                Utils.excMsg("Cannot create font " + fontName
                    + " " + config.FontSize + " pt", ex);
            }
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
            int buttonWidth = config.Size.Width / config.Cols;
            if (buttonWidth <= 0) buttonWidth = 50;
            int buttonHeight = config.Size.Height / config.Rows;
            if (buttonHeight <= 0) buttonHeight = 50;

            foreach (KeyDef keyDef in keyDefs) {
                keyButton = new KeyButton(keyDef);
                if (keyDef.Type == KeyDef.KeyType.UNUSED) {
                    keyButton.Text = "";
                    //keyButton.BackColor =
                    //    Color.FromKnownColor(KnownColor.ControlLight);
                } else {
                    keyButton.Text = keyDef.Name;
                }// Colors
                if (config.isValidFGColorString()) {
                    keyButton.ForeColor = config.getFgColor();
                }
                if (config.isValidBGColorString()) {
                    keyButton.BackColor = config.getBgColor();
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
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLoad");
#endif
            reconfigure(config);
        }

        /// <summary>
        /// ShowWithoutActivation is readonly and  needs to be overwritten to
        /// keep the Form from being activated when it is shown.
        /// </summary>
        protected override bool ShowWithoutActivation {
            get {
                return true;
            }
        }

        public Configuration Config {
            get {
                return config;
            }

            set {
                config = value;
            }
        }

        public string LastConfigFile {
            get {
                return lastConfigFile;
            }

            set {
                lastConfigFile = value;
            }
        }

        protected override void OnResizeEnd(System.EventArgs e) {
            base.OnResizeEnd(e);
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnResizeEnd (Before)");
#endif
            Tools.setForegroundWindowFromSaved();
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnResizeEnd (After)");
#endif
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnFormClosing");
#endif
            // Send up events for any pressed keys
            if (keyDefs != null) {
                Tools.sendUpEventsForPressedKeys(keyDefs);
            }
            Properties.Settings.Default.LastConfigFile = lastConfigFile;
            Properties.Settings.Default.LastLocation = Location;
            Properties.Settings.Default.Save();
            base.OnFormClosing(e);
        }

        private void ArtPadForm_Load(object sender, EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm_Load");
#endif
        }

        // Define debugging for determining when events are called
        // and the state of the foreground window
        #region Check events
#if CHECK_EVENTS

        protected override void OnMouseEnter(System.EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnMouseEnter");
#endif
            base.OnMouseEnter(e);
        }

        protected override void OnHandleCreated(System.EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnHandleCreated (Before)");
#endif
            base.OnHandleCreated(e);
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnHandleCreated (After)");
#endif
        }

        protected override void OnBindingContextChanged(System.EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnBindingContextChanged");
#endif
            base.OnBindingContextChanged(e);
        }

        protected override void OnActivated(System.EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnActivated (Before)");
#endif
            base.OnActivated(e);
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnActivated (After)");
#endif
        }

        protected override void OnVisibleChanged(System.EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnVisibleChanged");
#endif
            base.OnVisibleChanged(e);
        }

        protected override void OnShown(System.EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnShown");
#endif
            base.OnShown(e);
        }

        protected override void OnGotFocus(System.EventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnGotFocus");
#endif
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(System.EventArgs e) {
            base.OnLostFocus(e);
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnLostFocus");
#endif
        }

        protected override void OnLocationChanged(System.EventArgs e) {
#if DODEBUG && false
            Tools.debugForegroundWindows("ArtPadForm.OnLocationChanged");
#endif
            base.OnLocationChanged(e);
        }

        protected override void OnMouseLeave(System.EventArgs e) {
            base.OnMouseLeave(e);
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnMouseLeave");
#endif
        }

        protected override void OnMouseMove(MouseEventArgs e) {
#if DODEBUG
            Tools.debugForegroundWindows("ArtPadForm.OnMouseMove");
#endif
        }

#endif //CHECK_EVENTS
        #endregion Check events

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            if (moving && e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public void DoMouseDown(MouseEventArgs e) {
            OnMouseDown(e);
        }
    }
}

