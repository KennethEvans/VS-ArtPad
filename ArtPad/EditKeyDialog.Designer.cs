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
            this.components = new System.ComponentModel.Container();
            this.editKeyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelRowCol = new System.Windows.Forms.Label();
            this.flowLayoutPanelType = new System.Windows.Forms.FlowLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelKeyString = new System.Windows.Forms.Label();
            this.textBoxKeyString = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSetKey = new System.Windows.Forms.Button();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanelName = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelKeyString = new System.Windows.Forms.TableLayoutPanel();
            this.editKeyTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanelType.SuspendLayout();
            this.flowLayoutPanelButtons1.SuspendLayout();
            this.flowLayoutPanelButtons2.SuspendLayout();
            this.tableLayoutPanelName.SuspendLayout();
            this.tableLayoutPanelKeyString.SuspendLayout();
            this.SuspendLayout();
            // 
            // editKeyTableLayoutPanel
            // 
            this.editKeyTableLayoutPanel.AutoSize = true;
            this.editKeyTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editKeyTableLayoutPanel.ColumnCount = 1;
            this.editKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editKeyTableLayoutPanel.Controls.Add(this.flowLayoutPanelType, 0, 3);
            this.editKeyTableLayoutPanel.Controls.Add(this.labelRowCol, 0, 0);
            this.editKeyTableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons1, 0, 4);
            this.editKeyTableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons2, 0, 5);
            this.editKeyTableLayoutPanel.Controls.Add(this.tableLayoutPanelName, 0, 1);
            this.editKeyTableLayoutPanel.Controls.Add(this.tableLayoutPanelKeyString, 0, 2);
            this.editKeyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editKeyTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.editKeyTableLayoutPanel.Name = "editKeyTableLayoutPanel";
            this.editKeyTableLayoutPanel.RowCount = 6;
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editKeyTableLayoutPanel.Size = new System.Drawing.Size(313, 220);
            this.editKeyTableLayoutPanel.TabIndex = 0;
            this.editKeyTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editKeyTableLayoutPanel_Paint);
            // 
            // labelRowCol
            // 
            this.labelRowCol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRowCol.Location = new System.Drawing.Point(25, 10);
            this.labelRowCol.Margin = new System.Windows.Forms.Padding(10);
            this.labelRowCol.Name = "labelRowCol";
            this.labelRowCol.Size = new System.Drawing.Size(262, 17);
            this.labelRowCol.TabIndex = 0;
            this.labelRowCol.Text = "Edit Key (Row,Column)";
            this.labelRowCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelRowCol, "The position of the key you are editing.");
            // 
            // flowLayoutPanelType
            // 
            this.flowLayoutPanelType.AutoSize = true;
            this.flowLayoutPanelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelType.Controls.Add(this.labelType);
            this.flowLayoutPanelType.Controls.Add(this.comboBoxType);
            this.flowLayoutPanelType.Location = new System.Drawing.Point(3, 108);
            this.flowLayoutPanelType.Name = "flowLayoutPanelType";
            this.flowLayoutPanelType.Size = new System.Drawing.Size(247, 30);
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
            this.toolTip.SetToolTip(this.labelType, "The type of this key.");
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
            this.comboBoxType.Size = new System.Drawing.Size(191, 24);
            this.comboBoxType.TabIndex = 4;
            this.toolTip.SetToolTip(this.comboBoxType, "The type of this key.");
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
            this.toolTip.SetToolTip(this.labelKeyString, "The key string that is sent.");
            // 
            // textBoxKeyString
            // 
            this.textBoxKeyString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKeyString.Location = new System.Drawing.Point(86, 3);
            this.textBoxKeyString.Name = "textBoxKeyString";
            this.textBoxKeyString.Size = new System.Drawing.Size(218, 22);
            this.textBoxKeyString.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxKeyString, "The key string that is sent.");
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
            this.toolTip.SetToolTip(this.labelName, "The name that appears on the key.");
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(58, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(246, 22);
            this.textBoxName.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxName, "The name that appears on the key.");
            // 
            // flowLayoutPanelButtons1
            // 
            this.flowLayoutPanelButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons1.AutoSize = true;
            this.flowLayoutPanelButtons1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons1.Controls.Add(this.buttonCopy);
            this.flowLayoutPanelButtons1.Controls.Add(this.buttonPaste);
            this.flowLayoutPanelButtons1.Controls.Add(this.buttonReset);
            this.flowLayoutPanelButtons1.Location = new System.Drawing.Point(19, 144);
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
            this.toolTip.SetToolTip(this.buttonCopy, "Copy a Json string representing the current key settings to the clipboard.");
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
            this.toolTip.SetToolTip(this.buttonPaste, "Paste a Json string representing a key to the current settings in the dialog..");
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
            this.toolTip.SetToolTip(this.buttonReset, "Reset the key settings to the original values when starting to edit.");
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
            this.flowLayoutPanelButtons2.Location = new System.Drawing.Point(75, 183);
            this.flowLayoutPanelButtons2.Name = "flowLayoutPanelButtons2";
            this.flowLayoutPanelButtons2.Size = new System.Drawing.Size(162, 34);
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
            this.toolTip.SetToolTip(this.buttonSetKey, "Set the current values to the key button in ArtPad.");
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
            this.toolTip.SetToolTip(this.buttonDismiss, "Dismiss this dialog (make it not visible).");
            this.buttonDismiss.UseVisualStyleBackColor = true;
            this.buttonDismiss.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dismissButton_click);
            // 
            // tableLayoutPanelName
            // 
            this.tableLayoutPanelName.AutoSize = true;
            this.tableLayoutPanelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelName.ColumnCount = 2;
            this.tableLayoutPanelName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelName.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanelName.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelName.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanelName.Name = "tableLayoutPanelName";
            this.tableLayoutPanelName.RowCount = 1;
            this.tableLayoutPanelName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelName.Size = new System.Drawing.Size(307, 28);
            this.tableLayoutPanelName.TabIndex = 3;
            // 
            // tableLayoutPanelKeyString
            // 
            this.tableLayoutPanelKeyString.AutoSize = true;
            this.tableLayoutPanelKeyString.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelKeyString.ColumnCount = 2;
            this.tableLayoutPanelKeyString.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelKeyString.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelKeyString.Controls.Add(this.textBoxKeyString, 1, 0);
            this.tableLayoutPanelKeyString.Controls.Add(this.labelKeyString, 0, 0);
            this.tableLayoutPanelKeyString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelKeyString.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanelKeyString.Name = "tableLayoutPanelKeyString";
            this.tableLayoutPanelKeyString.RowCount = 1;
            this.tableLayoutPanelKeyString.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelKeyString.Size = new System.Drawing.Size(307, 28);
            this.tableLayoutPanelKeyString.TabIndex = 4;
            // 
            // EditKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(313, 220);
            this.Controls.Add(this.editKeyTableLayoutPanel);
            this.Name = "EditKeyDialog";
            this.Text = "Edit Key";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.editKeyTableLayoutPanel.ResumeLayout(false);
            this.editKeyTableLayoutPanel.PerformLayout();
            this.flowLayoutPanelType.ResumeLayout(false);
            this.flowLayoutPanelType.PerformLayout();
            this.flowLayoutPanelButtons1.ResumeLayout(false);
            this.flowLayoutPanelButtons1.PerformLayout();
            this.flowLayoutPanelButtons2.ResumeLayout(false);
            this.flowLayoutPanelButtons2.PerformLayout();
            this.tableLayoutPanelName.ResumeLayout(false);
            this.tableLayoutPanelName.PerformLayout();
            this.tableLayoutPanelKeyString.ResumeLayout(false);
            this.tableLayoutPanelKeyString.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel editKeyTableLayoutPanel;
        private System.Windows.Forms.Label labelRowCol;
        private System.Windows.Forms.Label labelKeyString;
        private System.Windows.Forms.TextBox textBoxKeyString;
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKeyString;
    }
}