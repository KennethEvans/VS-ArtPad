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
            this.flowLayoutPanelButtons2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDeleteKey = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.editKeyTableLayoutPanel.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.flowLayoutPanelType.SuspendLayout();
            this.flowLayoutPanelKeyString.SuspendLayout();
            this.flowLayoutName.SuspendLayout();
            this.flowLayoutPanelButtons1.SuspendLayout();
            this.flowLayoutPanelButtons2.SuspendLayout();
            this.flowLayoutPanelButtons3.SuspendLayout();
            this.flowLayoutPanelButtons4.SuspendLayout();
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
            this.editKeyTableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons3, 0, 4);
            this.editKeyTableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons4, 0, 5);
            this.editKeyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editKeyTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.editKeyTableLayoutPanel.Name = "editKeyTableLayoutPanel";
            this.editKeyTableLayoutPanel.RowCount = 7;
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editKeyTableLayoutPanel.Size = new System.Drawing.Size(282, 362);
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
            this.flowLayoutPanelButtons1.Location = new System.Drawing.Point(48, 194);
            this.flowLayoutPanelButtons1.Name = "flowLayoutPanelButtons1";
            this.flowLayoutPanelButtons1.Size = new System.Drawing.Size(186, 33);
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
            this.buttonCopy.Click += new System.EventHandler(this.copyButton_click);
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
            this.buttonPaste.Click += new System.EventHandler(this.pasteButton_click);
            // 
            // flowLayoutPanelButtons2
            // 
            this.flowLayoutPanelButtons2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons2.AutoSize = true;
            this.flowLayoutPanelButtons2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons2.Controls.Add(this.buttonDeleteKey);
            this.flowLayoutPanelButtons2.Controls.Add(this.button3);
            this.flowLayoutPanelButtons2.Controls.Add(this.button4);
            this.flowLayoutPanelButtons2.Location = new System.Drawing.Point(9, 233);
            this.flowLayoutPanelButtons2.Name = "flowLayoutPanelButtons2";
            this.flowLayoutPanelButtons2.Size = new System.Drawing.Size(263, 33);
            this.flowLayoutPanelButtons2.TabIndex = 2;
            // 
            // buttonDeleteKey
            // 
            this.buttonDeleteKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteKey.AutoSize = true;
            this.buttonDeleteKey.Location = new System.Drawing.Point(3, 3);
            this.buttonDeleteKey.Name = "buttonDeleteKey";
            this.buttonDeleteKey.Size = new System.Drawing.Size(87, 27);
            this.buttonDeleteKey.TabIndex = 1;
            this.buttonDeleteKey.Text = "Delete Key";
            this.buttonDeleteKey.UseVisualStyleBackColor = true;
            this.buttonDeleteKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteKeyButton_click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(96, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset Key";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resetKeyButton_click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(185, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 2;
            this.button4.Text = "Set Key";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setKeyButton_click);
            // 
            // flowLayoutPanelButtons3
            // 
            this.flowLayoutPanelButtons3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons3.AutoSize = true;
            this.flowLayoutPanelButtons3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons3.Controls.Add(this.buttonResetAll);
            this.flowLayoutPanelButtons3.Controls.Add(this.button6);
            this.flowLayoutPanelButtons3.Controls.Add(this.buttonSaveAll);
            this.flowLayoutPanelButtons3.Location = new System.Drawing.Point(19, 272);
            this.flowLayoutPanelButtons3.Name = "flowLayoutPanelButtons3";
            this.flowLayoutPanelButtons3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelButtons3.Size = new System.Drawing.Size(243, 33);
            this.flowLayoutPanelButtons3.TabIndex = 3;
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResetAll.Location = new System.Drawing.Point(3, 5);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(75, 23);
            this.buttonResetAll.TabIndex = 0;
            this.buttonResetAll.Text = "Reset All";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resetAllButton_click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(84, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 27);
            this.button6.TabIndex = 1;
            this.button6.Text = "Set All";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setAllButton_click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveAll.AutoSize = true;
            this.buttonSaveAll.Location = new System.Drawing.Point(165, 3);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(75, 27);
            this.buttonSaveAll.TabIndex = 2;
            this.buttonSaveAll.Text = "Save All";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveAllButton_click);
            // 
            // flowLayoutPanelButtons4
            // 
            this.flowLayoutPanelButtons4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons4.AutoSize = true;
            this.flowLayoutPanelButtons4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons4.Controls.Add(this.buttonDismiss);
            this.flowLayoutPanelButtons4.Location = new System.Drawing.Point(100, 311);
            this.flowLayoutPanelButtons4.Name = "flowLayoutPanelButtons4";
            this.flowLayoutPanelButtons4.Size = new System.Drawing.Size(81, 33);
            this.flowLayoutPanelButtons4.TabIndex = 4;
            this.flowLayoutPanelButtons4.WrapContents = false;
            // 
            // buttonDismiss
            // 
            this.buttonDismiss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDismiss.AutoSize = true;
            this.buttonDismiss.Location = new System.Drawing.Point(3, 3);
            this.buttonDismiss.Name = "buttonDismiss";
            this.buttonDismiss.Size = new System.Drawing.Size(75, 27);
            this.buttonDismiss.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(282, 362);
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
            this.flowLayoutPanelButtons3.ResumeLayout(false);
            this.flowLayoutPanelButtons3.PerformLayout();
            this.flowLayoutPanelButtons4.ResumeLayout(false);
            this.flowLayoutPanelButtons4.PerformLayout();
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
        private System.Windows.Forms.Button buttonDeleteKey;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons3;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons4;
        private System.Windows.Forms.Button buttonDismiss;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonPaste;
    }
}