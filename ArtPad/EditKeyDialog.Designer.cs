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
            this.flowLayoutPanelKeyString = new System.Windows.Forms.FlowLayoutPanel();
            this.labelKeyString = new System.Windows.Forms.Label();
            this.textBoxKeyString = new System.Windows.Forms.TextBox();
            this.flowLayoutEditPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDeleteKey = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.editKeyTableLayoutPanel.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.flowLayoutPanelType.SuspendLayout();
            this.flowLayoutPanelKeyString.SuspendLayout();
            this.flowLayoutEditPanel1.SuspendLayout();
            this.flowLayoutPanelButtons1.SuspendLayout();
            this.flowLayoutPanelButtons2.SuspendLayout();
            this.flowLayoutPanelButtons3.SuspendLayout();
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
            this.editKeyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editKeyTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.editKeyTableLayoutPanel.Name = "editKeyTableLayoutPanel";
            this.editKeyTableLayoutPanel.RowCount = 5;
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editKeyTableLayoutPanel.Size = new System.Drawing.Size(282, 331);
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
            this.groupBoxEdit.Controls.Add(this.comboBoxType);
            this.groupBoxEdit.Controls.Add(this.flowLayoutPanelType);
            this.groupBoxEdit.Controls.Add(this.flowLayoutPanelKeyString);
            this.groupBoxEdit.Controls.Add(this.flowLayoutEditPanel1);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEdit.Location = new System.Drawing.Point(3, 40);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(276, 145);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // flowLayoutPanelType
            // 
            this.flowLayoutPanelType.AutoSize = true;
            this.flowLayoutPanelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelType.Controls.Add(this.labelType);
            this.flowLayoutPanelType.Location = new System.Drawing.Point(12, 99);
            this.flowLayoutPanelType.Name = "flowLayoutPanelType";
            this.flowLayoutPanelType.Size = new System.Drawing.Size(50, 17);
            this.flowLayoutPanelType.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(3, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(44, 17);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type:";
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
            // flowLayoutEditPanel1
            // 
            this.flowLayoutEditPanel1.AutoSize = true;
            this.flowLayoutEditPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutEditPanel1.Controls.Add(this.labelName);
            this.flowLayoutEditPanel1.Controls.Add(this.textBoxName);
            this.flowLayoutEditPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutEditPanel1.Name = "flowLayoutEditPanel1";
            this.flowLayoutEditPanel1.Size = new System.Drawing.Size(161, 28);
            this.flowLayoutEditPanel1.TabIndex = 0;
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
            this.flowLayoutPanelButtons1.Controls.Add(this.buttonDeleteKey);
            this.flowLayoutPanelButtons1.Controls.Add(this.button3);
            this.flowLayoutPanelButtons1.Controls.Add(this.button4);
            this.flowLayoutPanelButtons1.Location = new System.Drawing.Point(9, 191);
            this.flowLayoutPanelButtons1.Name = "flowLayoutPanelButtons1";
            this.flowLayoutPanelButtons1.Size = new System.Drawing.Size(263, 33);
            this.flowLayoutPanelButtons1.TabIndex = 2;
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
            // 
            // flowLayoutPanelButtons2
            // 
            this.flowLayoutPanelButtons2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons2.AutoSize = true;
            this.flowLayoutPanelButtons2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons2.Controls.Add(this.buttonResetAll);
            this.flowLayoutPanelButtons2.Controls.Add(this.button6);
            this.flowLayoutPanelButtons2.Controls.Add(this.buttonSaveAll);
            this.flowLayoutPanelButtons2.Location = new System.Drawing.Point(19, 230);
            this.flowLayoutPanelButtons2.Name = "flowLayoutPanelButtons2";
            this.flowLayoutPanelButtons2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelButtons2.Size = new System.Drawing.Size(243, 33);
            this.flowLayoutPanelButtons2.TabIndex = 3;
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
            // 
            // flowLayoutPanelButtons3
            // 
            this.flowLayoutPanelButtons3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons3.AutoSize = true;
            this.flowLayoutPanelButtons3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons3.Controls.Add(this.buttonDismiss);
            this.flowLayoutPanelButtons3.Location = new System.Drawing.Point(100, 269);
            this.flowLayoutPanelButtons3.Name = "flowLayoutPanelButtons3";
            this.flowLayoutPanelButtons3.Size = new System.Drawing.Size(81, 59);
            this.flowLayoutPanelButtons3.TabIndex = 4;
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
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "NORMAL",
            "HOLD",
            "COMMAND"});
            this.comboBoxType.Location = new System.Drawing.Point(77, 100);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 3;
            // 
            // EditKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 331);
            this.Controls.Add(this.editKeyTableLayoutPanel);
            this.Name = "EditKeyDialog";
            this.Text = "Edit";
            this.editKeyTableLayoutPanel.ResumeLayout(false);
            this.editKeyTableLayoutPanel.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.flowLayoutPanelType.ResumeLayout(false);
            this.flowLayoutPanelType.PerformLayout();
            this.flowLayoutPanelKeyString.ResumeLayout(false);
            this.flowLayoutPanelKeyString.PerformLayout();
            this.flowLayoutEditPanel1.ResumeLayout(false);
            this.flowLayoutEditPanel1.PerformLayout();
            this.flowLayoutPanelButtons1.ResumeLayout(false);
            this.flowLayoutPanelButtons1.PerformLayout();
            this.flowLayoutPanelButtons2.ResumeLayout(false);
            this.flowLayoutPanelButtons2.PerformLayout();
            this.flowLayoutPanelButtons3.ResumeLayout(false);
            this.flowLayoutPanelButtons3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel editKeyTableLayoutPanel;
        private System.Windows.Forms.Label labelRowCol;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKeyString;
        private System.Windows.Forms.Label labelKeyString;
        private System.Windows.Forms.TextBox textBoxKeyString;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutEditPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons1;
        private System.Windows.Forms.Button buttonDeleteKey;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons2;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons3;
        private System.Windows.Forms.Button buttonDismiss;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}