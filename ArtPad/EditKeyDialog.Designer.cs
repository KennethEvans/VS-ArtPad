namespace ArtPad {
    partial class EditKeyDialog {
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
            this.editKeyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelRowCol = new System.Windows.Forms.Label();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelType = new System.Windows.Forms.FlowLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelKeyString = new System.Windows.Forms.FlowLayoutPanel();
            this.labelKeyString = new System.Windows.Forms.Label();
            this.textBoxKeyString = new System.Windows.Forms.TextBox();
            this.flowLayoutName = new System.Windows.Forms.FlowLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSetKey = new System.Windows.Forms.Button();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.editKeyTableLayoutPanel.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.flowLayoutPanelType.SuspendLayout();
            this.flowLayoutPanelKeyString.SuspendLayout();
            this.flowLayoutName.SuspendLayout();
            this.flowLayoutPanelButtons1.SuspendLayout();
            this.flowLayoutPanelButtons2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editKeyTableLayoutPanel
            // 
            this.editKeyTableLayoutPanel.AutoSize = true;
            this.editKeyTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editKeyTableLayoutPanel.ColumnCount = 1;
            this.editKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editKeyTableLayoutPanel.Controls.Add(this.labelRowCol, 0, 0);
            this.editKeyTableLayoutPanel.Controls.Add(this.groupBoxEdit, 0, 1);
            this.editKeyTableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons1, 0, 2);
            this.editKeyTableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons2, 0, 3);
            this.editKeyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editKeyTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.editKeyTableLayoutPanel.Name = "editKeyTableLayoutPanel";
            this.editKeyTableLayoutPanel.RowCount = 4;
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editKeyTableLayoutPanel.Size = new System.Drawing.Size(282, 275);
            this.editKeyTableLayoutPanel.TabIndex = 0;
            this.editKeyTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editKeyTableLayoutPanel_Paint);
            // 
            // labelRowCol
            // 
            this.labelRowCol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRowCol.Location = new System.Drawing.Point(10, 10);
            this.labelRowCol.Margin = new System.Windows.Forms.Padding(10);
            this.labelRowCol.Name = "labelRowCol";
            this.labelRowCol.Size = new System.Drawing.Size(262, 17);
            this.labelRowCol.TabIndex = 0;
            this.labelRowCol.Text = "Edit Key (Row,Column)";
            this.labelRowCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.AutoSize = true;
            this.groupBoxEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxEdit.Controls.Add(this.flowLayoutPanelType);
            this.groupBoxEdit.Controls.Add(this.flowLayoutPanelKeyString);
            this.groupBoxEdit.Controls.Add(this.flowLayoutName);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEdit.Location = new System.Drawing.Point(3, 40);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(276, 148);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // flowLayoutPanelType
            // 
            this.flowLayoutPanelType.AutoSize = true;
            this.flowLayoutPanelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelType.Controls.Add(this.labelType);
            this.flowLayoutPanelType.Controls.Add(this.comboBoxType);
            this.flowLayoutPanelType.Location = new System.Drawing.Point(12, 97);
            this.flowLayoutPanelType.Name = "flowLayoutPanelType";
            this.flowLayoutPanelType.Size = new System.Drawing.Size(177, 30);
            this.flowLayoutPanelType.TabIndex = 4;
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(3, 6);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(44, 17);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "NORMAL",
            "HOLD",
            "COMMAND",
            "UNUSED"});
            this.comboBoxType.Location = new System.Drawing.Point(53, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 4;
            // 
            // flowLayoutPanelKeyString
            // 
            this.flowLayoutPanelKeyString.AutoSize = true;
            this.flowLayoutPanelKeyString.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelKeyString.Controls.Add(this.labelKeyString);
            this.flowLayoutPanelKeyString.Controls.Add(this.textBoxKeyString);
            this.flowLayoutPanelKeyString.Location = new System.Drawing.Point(12, 63);
            this.flowLayoutPanelKeyString.Name = "flowLayoutPanelKeyString";
            this.flowLayoutPanelKeyString.Size = new System.Drawing.Size(189, 28);
            this.flowLayoutPanelKeyString.TabIndex = 1;
            // 
            // labelKeyString
            // 
            this.labelKeyString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelKeyString.AutoSize = true;
            this.labelKeyString.Location = new System.Drawing.Point(3, 5);
            this.labelKeyString.Name = "labelKeyString";
            this.labelKeyString.Size = new System.Drawing.Size(77, 17);
            this.labelKeyString.TabIndex = 0;
            this.labelKeyString.Text = "Key String:";
            // 
            // textBoxKeyString
            // 
            this.textBoxKeyString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxKeyString.Location = new System.Drawing.Point(86, 3);
            this.textBoxKeyString.Name = "textBoxKeyString";
            this.textBoxKeyString.Size = new System.Drawing.Size(100, 22);
            this.textBoxKeyString.TabIndex = 1;
            // 
            // flowLayoutName
            // 
            this.flowLayoutName.AutoSize = true;
            this.flowLayoutName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutName.Controls.Add(this.labelName);
            this.flowLayoutName.Controls.Add(this.textBoxName);
            this.flowLayoutName.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutName.Name = "flowLayoutName";
            this.flowLayoutName.Size = new System.Drawing.Size(161, 28);
            this.flowLayoutName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Location = new System.Drawing.Point(58, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // flowLayoutPanelButtons1
            // 
            this.flowLayoutPanelButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons1.AutoSize = true;
            this.flowLayoutPanelButtons1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons1.Controls.Add(this.buttonCopy);
            this.flowLayoutPanelButtons1.Controls.Add(this.buttonPaste);
            this.flowLayoutPanelButtons1.Controls.Add(this.buttonReset);
            this.flowLayoutPanelButtons1.Location = new System.Drawing.Point(3, 194);
            this.flowLayoutPanelButtons1.Name = "flowLayoutPanelButtons1";
            this.flowLayoutPanelButtons1.Size = new System.Drawing.Size(275, 33);
            this.flowLayoutPanelButtons1.TabIndex = 1;
            this.flowLayoutPanelButtons1.WrapContents = false;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCopy.AutoSize = true;
            this.buttonCopy.Location = new System.Drawing.Point(3, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(87, 27);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.copyButton_click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPaste.AutoSize = true;
            this.buttonPaste.Location = new System.Drawing.Point(96, 3);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(87, 27);
            this.buttonPaste.TabIndex = 3;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pasteButton_click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.AutoSize = true;
            this.buttonReset.Location = new System.Drawing.Point(189, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(83, 27);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resetButton_click);
            // 
            // flowLayoutPanelButtons2
            // 
            this.flowLayoutPanelButtons2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons2.AutoSize = true;
            this.flowLayoutPanelButtons2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons2.Controls.Add(this.buttonSetKey);
            this.flowLayoutPanelButtons2.Controls.Add(this.buttonDismiss);
            this.flowLayoutPanelButtons2.Location = new System.Drawing.Point(60, 233);
            this.flowLayoutPanelButtons2.Name = "flowLayoutPanelButtons2";
            this.flowLayoutPanelButtons2.Size = new System.Drawing.Size(162, 39);
            this.flowLayoutPanelButtons2.TabIndex = 2;
            // 
            // buttonSetKey
            // 
            this.buttonSetKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSetKey.AutoSize = true;
            this.buttonSetKey.Location = new System.Drawing.Point(3, 3);
            this.buttonSetKey.Name = "buttonSetKey";
            this.buttonSetKey.Size = new System.Drawing.Size(75, 27);
            this.buttonSetKey.TabIndex = 2;
            this.buttonSetKey.Text = "Set Key";
            this.buttonSetKey.UseVisualStyleBackColor = true;
            this.buttonSetKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setKeyButton_click);
            // 
            // buttonDismiss
            // 
            this.buttonDismiss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDismiss.AutoSize = true;
            this.buttonDismiss.Location = new System.Drawing.Point(84, 3);
            this.buttonDismiss.Name = "buttonDismiss";
            this.buttonDismiss.Size = new System.Drawing.Size(75, 27);
            this.buttonDismiss.TabIndex = 3;
            this.buttonDismiss.Text = "Dismiss";
            this.buttonDismiss.UseVisualStyleBackColor = true;
            this.buttonDismiss.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dismissButton_click);
            // 
            // EditKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 275);
            this.Controls.Add(this.editKeyTableLayoutPanel);
            this.Name = "EditKeyDialog";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.editKeyTableLayoutPanel.ResumeLayout(false);
            this.editKeyTableLayoutPanel.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.flowLayoutPanelType.ResumeLayout(false);
            this.flowLayoutPanelType.PerformLayout();
            this.flowLayoutPanelKeyString.ResumeLayout(false);
            this.flowLayoutPanelKeyString.PerformLayout();
            this.flowLayoutName.ResumeLayout(false);
            this.flowLayoutName.PerformLayout();
            this.flowLayoutPanelButtons1.ResumeLayout(false);
            this.flowLayoutPanelButtons1.PerformLayout();
            this.flowLayoutPanelButtons2.ResumeLayout(false);
            this.flowLayoutPanelButtons2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel editKeyTableLayoutPanel;
        private System.Windows.Forms.Label labelRowCol;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKeyString;
        private System.Windows.Forms.Label labelKeyString;
        private System.Windows.Forms.TextBox textBoxKeyString;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons2;
        private System.Windows.Forms.Button buttonSetKey;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDismiss;
    }
}