using System.Windows.Forms;

namespace ArtPad {
    partial class AppearanceDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppearanceDialog));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelFontName = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFontName = new System.Windows.Forms.Label();
            this.comboBoxFontName = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelFontSize = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelWidth = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelHeight = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop.SuspendLayout();
            this.flowLayoutPanelFontName.SuspendLayout();
            this.flowLayoutPanelFontSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.flowLayoutPanelWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.flowLayoutPanelHeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 1;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelFontName, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelFontSize, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelWidth, 0, 2);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelHeight, 0, 4);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelButtons, 0, 5);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 5;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(662, 323);
            this.tableLayoutPanelTop.TabIndex = 2;
            // 
            // flowLayoutPanelFontName
            // 
            this.flowLayoutPanelFontName.AutoSize = true;
            this.flowLayoutPanelFontName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFontName.Controls.Add(this.labelFontName);
            this.flowLayoutPanelFontName.Controls.Add(this.comboBoxFontName);
            this.flowLayoutPanelFontName.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanelFontName.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelFontName.Name = "flowLayoutPanelFontName";
            this.flowLayoutPanelFontName.Size = new System.Drawing.Size(620, 45);
            this.flowLayoutPanelFontName.TabIndex = 0;
            this.flowLayoutPanelFontName.WrapContents = false;
            // 
            // labelFontName
            // 
            this.labelFontName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFontName.AutoSize = true;
            this.labelFontName.Location = new System.Drawing.Point(6, 6);
            this.labelFontName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFontName.Name = "labelFontName";
            this.labelFontName.Size = new System.Drawing.Size(154, 32);
            this.labelFontName.TabIndex = 0;
            this.labelFontName.Text = "Font Name";
            // 
            // comboBoxFontName
            // 
            this.comboBoxFontName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxFontName.FormattingEnabled = true;
            this.comboBoxFontName.Location = new System.Drawing.Point(169, 3);
            this.comboBoxFontName.Name = "comboBoxFontName";
            this.comboBoxFontName.Size = new System.Drawing.Size(448, 39);
            this.comboBoxFontName.TabIndex = 2;
            // 
            // flowLayoutPanelFontSize
            // 
            this.flowLayoutPanelFontSize.AutoSize = true;
            this.flowLayoutPanelFontSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFontSize.Controls.Add(this.labelFontSize);
            this.flowLayoutPanelFontSize.Controls.Add(this.numericUpDownFontSize);
            this.flowLayoutPanelFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFontSize.Location = new System.Drawing.Point(6, 63);
            this.flowLayoutPanelFontSize.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelFontSize.Name = "flowLayoutPanelFontSize";
            this.flowLayoutPanelFontSize.Size = new System.Drawing.Size(650, 50);
            this.flowLayoutPanelFontSize.TabIndex = 1;
            this.flowLayoutPanelFontSize.WrapContents = false;
            // 
            // labelFontSize
            // 
            this.labelFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(6, 9);
            this.labelFontSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(184, 32);
            this.labelFontSize.TabIndex = 0;
            this.labelFontSize.Text = "Font Size (pt)";
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownFontSize.Location = new System.Drawing.Point(202, 6);
            this.numericUpDownFontSize.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(240, 38);
            this.numericUpDownFontSize.TabIndex = 1;
            // 
            // flowLayoutPanelWidth
            // 
            this.flowLayoutPanelWidth.AutoSize = true;
            this.flowLayoutPanelWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelWidth.Controls.Add(this.labelWidth);
            this.flowLayoutPanelWidth.Controls.Add(this.numericUpDownWidth);
            this.flowLayoutPanelWidth.Location = new System.Drawing.Point(6, 125);
            this.flowLayoutPanelWidth.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelWidth.Name = "flowLayoutPanelWidth";
            this.flowLayoutPanelWidth.Size = new System.Drawing.Size(352, 50);
            this.flowLayoutPanelWidth.TabIndex = 3;
            this.flowLayoutPanelWidth.WrapContents = false;
            // 
            // labelWidth
            // 
            this.labelWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 9);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(88, 32);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownWidth.Location = new System.Drawing.Point(106, 6);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(240, 38);
            this.numericUpDownWidth.TabIndex = 1;
            // 
            // flowLayoutPanelHeight
            // 
            this.flowLayoutPanelHeight.AutoSize = true;
            this.flowLayoutPanelHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelHeight.Controls.Add(this.labelHeight);
            this.flowLayoutPanelHeight.Controls.Add(this.numericUpDownHeight);
            this.flowLayoutPanelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHeight.Location = new System.Drawing.Point(6, 187);
            this.flowLayoutPanelHeight.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelHeight.Name = "flowLayoutPanelHeight";
            this.flowLayoutPanelHeight.Size = new System.Drawing.Size(650, 50);
            this.flowLayoutPanelHeight.TabIndex = 4;
            this.flowLayoutPanelHeight.WrapContents = false;
            // 
            // labelHeight
            // 
            this.labelHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 9);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(98, 32);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "Height";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownHeight.Location = new System.Drawing.Point(116, 6);
            this.numericUpDownHeight.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(240, 38);
            this.numericUpDownHeight.TabIndex = 1;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons.Controls.Add(this.buttonOk);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(169, 249);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(324, 68);
            this.flowLayoutPanelButtons.TabIndex = 2;
            this.flowLayoutPanelButtons.WrapContents = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(6, 6);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(150, 45);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(168, 6);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 45);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AppearanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(662, 323);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppearanceDialog";
            this.Text = "Appearance";
            this.TopMost = true;
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.flowLayoutPanelFontName.ResumeLayout(false);
            this.flowLayoutPanelFontName.PerformLayout();
            this.flowLayoutPanelFontSize.ResumeLayout(false);
            this.flowLayoutPanelFontSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.flowLayoutPanelWidth.ResumeLayout(false);
            this.flowLayoutPanelWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.flowLayoutPanelHeight.ResumeLayout(false);
            this.flowLayoutPanelHeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFontName;
        private System.Windows.Forms.Label labelFontName;
        private System.Windows.Forms.ComboBox comboBoxFontName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFontSize;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;

        public Label LabelFontName
        {
            get
            {
                return labelFontName;
            }

            set
            {
                labelFontName = value;
            }
        }

        public ComboBox ComboBoxFontName
        {
            get
            {
                return comboBoxFontName;
            }

            set
            {
                comboBoxFontName = value;
            }
        }

        public Label LabelFontSize
        {
            get
            {
                return labelFontSize;
            }

            set
            {
                labelFontSize = value;
            }
        }

        public NumericUpDown NumericUpDownFontSize
        {
            get
            {
                return numericUpDownFontSize;
            }

            set
            {
                numericUpDownFontSize = value;
            }
        }

        public Button ButtonOk
        {
            get
            {
                return buttonOk;
            }

            set
            {
                buttonOk = value;
            }
        }

        public Button ButtonCancel
        {
            get
            {
                return buttonCancel;
            }

            set
            {
                buttonCancel = value;
            }
        }

        public Label LabelWidth
        {
            get
            {
                return labelWidth;
            }

            set
            {
                labelWidth = value;
            }
        }

        public NumericUpDown NumericUpDownWidth
        {
            get
            {
                return numericUpDownWidth;
            }

            set
            {
                numericUpDownWidth = value;
            }
        }

        public Label LabelHeight
        {
            get
            {
                return labelHeight;
            }

            set
            {
                labelHeight = value;
            }
        }

        public NumericUpDown NumericUpDownHeight
        {
            get
            {
                return numericUpDownHeight;
            }

            set
            {
                numericUpDownHeight = value;
            }
        }
    }
}