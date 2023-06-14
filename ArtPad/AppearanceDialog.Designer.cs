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
            this.flowLayoutPanelFontStyles = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
            this.checkBoxStrikeout = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelFontSize = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelFg = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFg = new System.Windows.Forms.Label();
            this.textBoxFg = new System.Windows.Forms.TextBox();
            this.buttonFg = new System.Windows.Forms.Button();
            this.flowLayoutPanelBg = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBg = new System.Windows.Forms.Label();
            this.textBoxBg = new System.Windows.Forms.TextBox();
            this.buttonBg = new System.Windows.Forms.Button();
            this.flowLayoutPanelWidth = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelHeight = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanelTitleBar = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.comboBoxTitleBar = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelTop.SuspendLayout();
            this.flowLayoutPanelFontName.SuspendLayout();
            this.flowLayoutPanelFontStyles.SuspendLayout();
            this.flowLayoutPanelFontSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.flowLayoutPanelFg.SuspendLayout();
            this.flowLayoutPanelBg.SuspendLayout();
            this.flowLayoutPanelWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.flowLayoutPanelHeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.flowLayoutPanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.AutoSize = true;
            this.tableLayoutPanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelTop.ColumnCount = 1;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelFontName, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelFontStyles, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelFontSize, 0, 2);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelFg, 0, 3);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelBg, 0, 4);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelWidth, 0, 5);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelHeight, 0, 6);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelTitleBar, 0, 7);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelButtons, 0, 8);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 9;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(641, 569);
            this.tableLayoutPanelTop.TabIndex = 0;
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
            this.flowLayoutPanelFontName.Size = new System.Drawing.Size(618, 46);
            this.flowLayoutPanelFontName.TabIndex = 0;
            this.flowLayoutPanelFontName.WrapContents = false;
            // 
            // labelFontName
            // 
            this.labelFontName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFontName.AutoSize = true;
            this.labelFontName.Location = new System.Drawing.Point(6, 7);
            this.labelFontName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFontName.Name = "labelFontName";
            this.labelFontName.Size = new System.Drawing.Size(153, 32);
            this.labelFontName.TabIndex = 0;
            this.labelFontName.Text = "Font Name";
            // 
            // comboBoxFontName
            // 
            this.comboBoxFontName.FormattingEnabled = true;
            this.comboBoxFontName.Location = new System.Drawing.Point(168, 3);
            this.comboBoxFontName.Name = "comboBoxFontName";
            this.comboBoxFontName.Size = new System.Drawing.Size(447, 39);
            this.comboBoxFontName.TabIndex = 1;
            // 
            // flowLayoutPanelFontStyles
            // 
            this.flowLayoutPanelFontStyles.AutoSize = true;
            this.flowLayoutPanelFontStyles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFontStyles.Controls.Add(this.checkBoxBold);
            this.flowLayoutPanelFontStyles.Controls.Add(this.checkBoxItalic);
            this.flowLayoutPanelFontStyles.Controls.Add(this.checkBoxUnderline);
            this.flowLayoutPanelFontStyles.Controls.Add(this.checkBoxStrikeout);
            this.flowLayoutPanelFontStyles.Location = new System.Drawing.Point(6, 64);
            this.flowLayoutPanelFontStyles.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelFontStyles.Name = "flowLayoutPanelFontStyles";
            this.flowLayoutPanelFontStyles.Size = new System.Drawing.Size(585, 42);
            this.flowLayoutPanelFontStyles.TabIndex = 7;
            this.flowLayoutPanelFontStyles.WrapContents = false;
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(110, 36);
            this.checkBoxBold.TabIndex = 2;
            this.checkBoxBold.Text = "Bold";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Location = new System.Drawing.Point(119, 3);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(111, 36);
            this.checkBoxItalic.TabIndex = 3;
            this.checkBoxItalic.Text = "Italic";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnderline
            // 
            this.checkBoxUnderline.AutoSize = true;
            this.checkBoxUnderline.Location = new System.Drawing.Point(236, 3);
            this.checkBoxUnderline.Name = "checkBoxUnderline";
            this.checkBoxUnderline.Size = new System.Drawing.Size(175, 36);
            this.checkBoxUnderline.TabIndex = 4;
            this.checkBoxUnderline.Text = "Underline";
            this.checkBoxUnderline.UseVisualStyleBackColor = true;
            // 
            // checkBoxStrikeout
            // 
            this.checkBoxStrikeout.AutoSize = true;
            this.checkBoxStrikeout.Location = new System.Drawing.Point(417, 3);
            this.checkBoxStrikeout.Name = "checkBoxStrikeout";
            this.checkBoxStrikeout.Size = new System.Drawing.Size(165, 36);
            this.checkBoxStrikeout.TabIndex = 5;
            this.checkBoxStrikeout.Text = "Strikeout";
            this.checkBoxStrikeout.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelFontSize
            // 
            this.flowLayoutPanelFontSize.AutoSize = true;
            this.flowLayoutPanelFontSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFontSize.Controls.Add(this.labelFontSize);
            this.flowLayoutPanelFontSize.Controls.Add(this.numericUpDownFontSize);
            this.flowLayoutPanelFontSize.Location = new System.Drawing.Point(6, 118);
            this.flowLayoutPanelFontSize.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelFontSize.Name = "flowLayoutPanelFontSize";
            this.flowLayoutPanelFontSize.Size = new System.Drawing.Size(447, 50);
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
            this.labelFontSize.Size = new System.Drawing.Size(183, 32);
            this.labelFontSize.TabIndex = 0;
            this.labelFontSize.Text = "Font Size (pt)";
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownFontSize.Location = new System.Drawing.Point(201, 6);
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
            // flowLayoutPanelFg
            // 
            this.flowLayoutPanelFg.AutoSize = true;
            this.flowLayoutPanelFg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFg.Controls.Add(this.labelFg);
            this.flowLayoutPanelFg.Controls.Add(this.textBoxFg);
            this.flowLayoutPanelFg.Controls.Add(this.buttonFg);
            this.flowLayoutPanelFg.Location = new System.Drawing.Point(6, 180);
            this.flowLayoutPanelFg.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelFg.Name = "flowLayoutPanelFg";
            this.flowLayoutPanelFg.Size = new System.Drawing.Size(615, 57);
            this.flowLayoutPanelFg.TabIndex = 2;
            this.flowLayoutPanelFg.WrapContents = false;
            // 
            // labelFg
            // 
            this.labelFg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFg.AutoSize = true;
            this.labelFg.Location = new System.Drawing.Point(6, 12);
            this.labelFg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFg.Name = "labelFg";
            this.labelFg.Size = new System.Drawing.Size(236, 32);
            this.labelFg.TabIndex = 0;
            this.labelFg.Text = "Foreground Color";
            // 
            // textBoxFg
            // 
            this.textBoxFg.Location = new System.Drawing.Point(251, 3);
            this.textBoxFg.Name = "textBoxFg";
            this.textBoxFg.Size = new System.Drawing.Size(199, 38);
            this.textBoxFg.TabIndex = 1;
            // 
            // buttonFg
            // 
            this.buttonFg.Location = new System.Drawing.Point(459, 6);
            this.buttonFg.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFg.Name = "buttonFg";
            this.buttonFg.Size = new System.Drawing.Size(150, 45);
            this.buttonFg.TabIndex = 2;
            this.buttonFg.Text = "Select";
            this.buttonFg.UseVisualStyleBackColor = true;
            this.buttonFg.Click += new System.EventHandler(this.buttonFg_click);
            // 
            // flowLayoutPanelBg
            // 
            this.flowLayoutPanelBg.AutoSize = true;
            this.flowLayoutPanelBg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelBg.Controls.Add(this.labelBg);
            this.flowLayoutPanelBg.Controls.Add(this.textBoxBg);
            this.flowLayoutPanelBg.Controls.Add(this.buttonBg);
            this.flowLayoutPanelBg.Location = new System.Drawing.Point(6, 249);
            this.flowLayoutPanelBg.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelBg.Name = "flowLayoutPanelBg";
            this.flowLayoutPanelBg.Size = new System.Drawing.Size(620, 57);
            this.flowLayoutPanelBg.TabIndex = 3;
            this.flowLayoutPanelBg.WrapContents = false;
            // 
            // labelBg
            // 
            this.labelBg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBg.AutoSize = true;
            this.labelBg.Location = new System.Drawing.Point(6, 12);
            this.labelBg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBg.Name = "labelBg";
            this.labelBg.Size = new System.Drawing.Size(241, 32);
            this.labelBg.TabIndex = 0;
            this.labelBg.Text = "Background Color";
            // 
            // textBoxBg
            // 
            this.textBoxBg.Location = new System.Drawing.Point(256, 3);
            this.textBoxBg.Name = "textBoxBg";
            this.textBoxBg.Size = new System.Drawing.Size(199, 38);
            this.textBoxBg.TabIndex = 1;
            // 
            // buttonBg
            // 
            this.buttonBg.Location = new System.Drawing.Point(464, 6);
            this.buttonBg.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBg.Name = "buttonBg";
            this.buttonBg.Size = new System.Drawing.Size(150, 45);
            this.buttonBg.TabIndex = 2;
            this.buttonBg.Text = "Select";
            this.buttonBg.UseVisualStyleBackColor = true;
            this.buttonBg.Click += new System.EventHandler(this.buttonBg_click);
            // 
            // flowLayoutPanelWidth
            // 
            this.flowLayoutPanelWidth.AutoSize = true;
            this.flowLayoutPanelWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelWidth.Controls.Add(this.labelWidth);
            this.flowLayoutPanelWidth.Controls.Add(this.numericUpDownWidth);
            this.flowLayoutPanelWidth.Location = new System.Drawing.Point(6, 318);
            this.flowLayoutPanelWidth.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelWidth.Name = "flowLayoutPanelWidth";
            this.flowLayoutPanelWidth.Size = new System.Drawing.Size(351, 50);
            this.flowLayoutPanelWidth.TabIndex = 4;
            this.flowLayoutPanelWidth.WrapContents = false;
            // 
            // labelWidth
            // 
            this.labelWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 9);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(87, 32);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownWidth.Location = new System.Drawing.Point(105, 6);
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
            this.flowLayoutPanelHeight.Location = new System.Drawing.Point(6, 380);
            this.flowLayoutPanelHeight.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelHeight.Name = "flowLayoutPanelHeight";
            this.flowLayoutPanelHeight.Size = new System.Drawing.Size(361, 50);
            this.flowLayoutPanelHeight.TabIndex = 5;
            this.flowLayoutPanelHeight.WrapContents = false;
            // 
            // labelHeight
            // 
            this.labelHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 9);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(97, 32);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "Height";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownHeight.Location = new System.Drawing.Point(115, 6);
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
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(158, 499);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(324, 64);
            this.flowLayoutPanelButtons.TabIndex = 6;
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
            // flowLayoutPanelTitleBar
            // 
            this.flowLayoutPanelTitleBar.AutoSize = true;
            this.flowLayoutPanelTitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTitleBar.Controls.Add(this.labelTitleBar);
            this.flowLayoutPanelTitleBar.Controls.Add(this.comboBoxTitleBar);
            this.flowLayoutPanelTitleBar.Location = new System.Drawing.Point(6, 442);
            this.flowLayoutPanelTitleBar.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelTitleBar.Name = "flowLayoutPanelTitleBar";
            this.flowLayoutPanelTitleBar.Size = new System.Drawing.Size(438, 45);
            this.flowLayoutPanelTitleBar.TabIndex = 8;
            this.flowLayoutPanelTitleBar.WrapContents = false;
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitleBar.AutoSize = true;
            this.labelTitleBar.Location = new System.Drawing.Point(6, 6);
            this.labelTitleBar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Size = new System.Drawing.Size(120, 32);
            this.labelTitleBar.TabIndex = 0;
            this.labelTitleBar.Text = "Title Bar";
            // 
            // comboBoxTitleBar
            // 
            this.comboBoxTitleBar.FormattingEnabled = true;
            this.comboBoxTitleBar.Items.AddRange(new object[] {
            "Default",
            "Minimal & Sizeable",
            "Minimal"});
            this.comboBoxTitleBar.Location = new System.Drawing.Point(135, 3);
            this.comboBoxTitleBar.Name = "comboBoxTitleBar";
            this.comboBoxTitleBar.Size = new System.Drawing.Size(300, 39);
            this.comboBoxTitleBar.TabIndex = 2;
            // 
            // AppearanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(641, 569);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppearanceDialog";
            this.Text = "Appearance";
            this.TopMost = true;
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.flowLayoutPanelFontName.ResumeLayout(false);
            this.flowLayoutPanelFontName.PerformLayout();
            this.flowLayoutPanelFontStyles.ResumeLayout(false);
            this.flowLayoutPanelFontStyles.PerformLayout();
            this.flowLayoutPanelFontSize.ResumeLayout(false);
            this.flowLayoutPanelFontSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.flowLayoutPanelFg.ResumeLayout(false);
            this.flowLayoutPanelFg.PerformLayout();
            this.flowLayoutPanelBg.ResumeLayout(false);
            this.flowLayoutPanelBg.PerformLayout();
            this.flowLayoutPanelWidth.ResumeLayout(false);
            this.flowLayoutPanelWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.flowLayoutPanelHeight.ResumeLayout(false);
            this.flowLayoutPanelHeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flowLayoutPanelTitleBar.ResumeLayout(false);
            this.flowLayoutPanelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private FlowLayoutPanel flowLayoutPanelBg;
        private Label labelBg;
        private FlowLayoutPanel flowLayoutPanelFg;
        private Label labelFg;
        private TextBox textBoxFg;
        private Button buttonFg;
        private TextBox textBoxBg;
        private Button buttonBg;
        private FlowLayoutPanel flowLayoutPanelFontStyles;
        private CheckBox checkBoxBold;
        private CheckBox checkBoxItalic;
        private CheckBox checkBoxUnderline;
        private CheckBox checkBoxStrikeout;
        private FlowLayoutPanel flowLayoutPanelTitleBar;
        private Label labelTitleBar;
        private ComboBox comboBoxTitleBar;

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

        public Label LabelFg
        {
            get
            {
                return labelFg;
            }

            set
            {
                labelFg = value;
            }
        }

        public TextBox TextBoxFg
        {
            get
            {
                return textBoxFg;
            }

            set
            {
                textBoxFg = value;
            }
        }

        public Button ButtonFg
        {
            get
            {
                return buttonFg;
            }

            set
            {
                buttonFg = value;
            }
        }

        public TextBox TextBoxBg {
            get {
                return textBoxBg;
            }

            set {
                textBoxBg = value;
            }
        }

        public ComboBox ComboBoxTitleBar {
            get {
                return comboBoxTitleBar;
            }

            set {
                comboBoxTitleBar = value;
            }
        }

        public Button ButtonBg
        {
            get
            {
                return buttonBg;
            }

            set
            {
                buttonBg = value;
            }
        }

        public CheckBox CheckBoxBold
        {
            get
            {
                return checkBoxBold;
            }

            set
            {
                checkBoxBold = value;
            }
        }

        public CheckBox CheckBoxItalic
        {
            get
            {
                return checkBoxItalic;
            }

            set
            {
                checkBoxItalic = value;
            }
        }

        public CheckBox CheckBoxUnderline
        {
            get
            {
                return checkBoxUnderline;
            }

            set
            {
                checkBoxUnderline = value;
            }
        }

        public CheckBox CheckBoxStrikeout
        {
            get
            {
                return checkBoxStrikeout;
            }

            set
            {
                checkBoxStrikeout = value;
            }
        }
    }
}