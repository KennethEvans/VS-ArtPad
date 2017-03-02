using System.Windows.Forms;

namespace ArtPad {
    partial class KeyButton {
        private AutoScaleMode AutoScaleMode;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPasteKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddRowBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddRowAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDeleteCol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddColBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddColAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetKeySize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHoldKeysUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditKey,
            this.toolStripMenuItemCopyKey,
            this.toolStripMenuItemPasteKey,
            this.toolStripMenuItemEditKeys,
            this.toolStripSeparator1,
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSaveAs,
            this.toolStripSeparator4,
            this.toolStripMenuItemHoldKeysUp,
            this.toolStripSeparator5,
            this.toolStripMenuItemHelp});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(451, 390);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // toolStripMenuItemEditKey
            // 
            this.toolStripMenuItemEditKey.Name = "toolStripMenuItemEditKey";
            this.toolStripMenuItemEditKey.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemEditKey.Text = "Edit Key...";
            this.toolStripMenuItemEditKey.ToolTipText = "Edit this key.";
            // 
            // toolStripMenuItemCopyKey
            // 
            this.toolStripMenuItemCopyKey.Name = "toolStripMenuItemCopyKey";
            this.toolStripMenuItemCopyKey.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemCopyKey.Text = "Copy Key";
            this.toolStripMenuItemCopyKey.ToolTipText = "Copy the definition for this key to the clipboard.";
            // 
            // toolStripMenuItemPasteKey
            // 
            this.toolStripMenuItemPasteKey.Name = "toolStripMenuItemPasteKey";
            this.toolStripMenuItemPasteKey.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemPasteKey.Text = "Paste Key";
            this.toolStripMenuItemPasteKey.ToolTipText = "Set the definition for this key from a key definition in the clipboard.";
            // 
            // toolStripMenuItemEditKeys
            // 
            this.toolStripMenuItemEditKeys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteRow,
            this.toolStripMenuItemAddRowBefore,
            this.toolStripMenuItemAddRowAfter,
            this.toolStripSeparator2,
            this.toolStripMenuItemDeleteCol,
            this.toolStripMenuItemAddColBefore,
            this.toolStripMenuItemAddColAfter,
            this.toolStripSeparator3,
            this.toolStripMenuItemSetKeySize,
            this.toolStripMenuItemSetFont,
            this.toolStripMenuItemSort,
            this.toolStripSeparator6,
            this.toolStripMenuItemCreateNew});
            this.toolStripMenuItemEditKeys.Name = "toolStripMenuItemEditKeys";
            this.toolStripMenuItemEditKeys.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemEditKeys.Text = "Edit Key Configuration...";
            this.toolStripMenuItemEditKeys.ToolTipText = "Edit the key configuration.";
            // 
            // toolStripMenuItemDeleteRow
            // 
            this.toolStripMenuItemDeleteRow.Name = "toolStripMenuItemDeleteRow";
            this.toolStripMenuItemDeleteRow.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemDeleteRow.Text = "Delete Row";
            this.toolStripMenuItemDeleteRow.ToolTipText = "Delete this row.";
            // 
            // toolStripMenuItemAddRowBefore
            // 
            this.toolStripMenuItemAddRowBefore.Name = "toolStripMenuItemAddRowBefore";
            this.toolStripMenuItemAddRowBefore.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemAddRowBefore.Text = "Add Row Before";
            this.toolStripMenuItemAddRowBefore.ToolTipText = "Add a row before this one.";
            // 
            // toolStripMenuItemAddRowAfter
            // 
            this.toolStripMenuItemAddRowAfter.Name = "toolStripMenuItemAddRowAfter";
            this.toolStripMenuItemAddRowAfter.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemAddRowAfter.Text = "Add Row After";
            this.toolStripMenuItemAddRowAfter.ToolTipText = "Add a row after this one.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(495, 6);
            // 
            // toolStripMenuItemDeleteCol
            // 
            this.toolStripMenuItemDeleteCol.Name = "toolStripMenuItemDeleteCol";
            this.toolStripMenuItemDeleteCol.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemDeleteCol.Text = "Delete Column";
            this.toolStripMenuItemDeleteCol.ToolTipText = "Delete this column.";
            // 
            // toolStripMenuItemAddColBefore
            // 
            this.toolStripMenuItemAddColBefore.Name = "toolStripMenuItemAddColBefore";
            this.toolStripMenuItemAddColBefore.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemAddColBefore.Text = "Add Column Before";
            this.toolStripMenuItemAddColBefore.ToolTipText = "Add a column before this one.";
            // 
            // toolStripMenuItemAddColAfter
            // 
            this.toolStripMenuItemAddColAfter.Name = "toolStripMenuItemAddColAfter";
            this.toolStripMenuItemAddColAfter.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemAddColAfter.Text = "Add Column After";
            this.toolStripMenuItemAddColAfter.ToolTipText = "Add a column after this one.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(495, 6);
            // 
            // toolStripMenuItemCreateNew
            // 
            this.toolStripMenuItemCreateNew.Name = "toolStripMenuItemCreateNew";
            this.toolStripMenuItemCreateNew.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemCreateNew.Text = "Create New Configuration...";
            this.toolStripMenuItemCreateNew.ToolTipText = "Create a new key configuration .";
            // 
            // toolStripMenuItemSetKeySize
            // 
            this.toolStripMenuItemSetKeySize.Name = "toolStripMenuItemSetKeySize";
            this.toolStripMenuItemSetKeySize.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemSetKeySize.Text = "Set Key Size...";
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemSort.Text = "Sort";
            this.toolStripMenuItemSort.ToolTipText = "Sort the key configuration list.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(447, 6);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemLoad.Text = "Load Configuration...";
            this.toolStripMenuItemLoad.ToolTipText = "Load a new configuration file.";
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemSaveAs.Text = "Save Configuration As...";
            this.toolStripMenuItemSaveAs.ToolTipText = "Save the current configuration.";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(447, 6);
            // 
            // toolStripMenuItemHoldKeysUp
            // 
            this.toolStripMenuItemHoldKeysUp.Name = "toolStripMenuItemHoldKeysUp";
            this.toolStripMenuItemHoldKeysUp.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemHoldKeysUp.Text = "Send Hold Keys Up";
            this.toolStripMenuItemHoldKeysUp.ToolTipText = "Send up events for all hold keys. (May fix application in a bad state.)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(447, 6);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOverview,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(450, 46);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemOverview
            // 
            this.toolStripMenuItemOverview.Name = "toolStripMenuItemOverview";
            this.toolStripMenuItemOverview.Size = new System.Drawing.Size(276, 46);
            this.toolStripMenuItemOverview.Text = "Overview...";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(276, 46);
            this.toolStripMenuItemAbout.Text = "About...";
            // 
            // toolStripMenuItemSetFont
            // 
            this.toolStripMenuItemSetFont.Name = "toolStripMenuItemSetFont";
            this.toolStripMenuItemSetFont.Size = new System.Drawing.Size(498, 46);
            this.toolStripMenuItemSetFont.Text = "Set Font...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(495, 6);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripMenuItemLoad;
        private ToolStripMenuItem toolStripMenuItemEditKey;
        private ToolStripMenuItem toolStripMenuItemSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemEditKeys;
        private ToolStripMenuItem toolStripMenuItemDeleteRow;
        private ToolStripMenuItem toolStripMenuItemAddRowBefore;
        private ToolStripMenuItem toolStripMenuItemAddRowAfter;
        private ToolStripMenuItem toolStripMenuItemDeleteCol;
        private ToolStripMenuItem toolStripMenuItemAddColBefore;
        private ToolStripMenuItem toolStripMenuItemAddColAfter;
        private ToolStripMenuItem toolStripMenuItemSort;
        private ToolStripMenuItem toolStripMenuItemCreateNew;
        private ToolStripMenuItem toolStripMenuItemSetKeySize;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItemHoldKeysUp;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItemCopyKey;
        private ToolStripMenuItem toolStripMenuItemPasteKey;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemOverview;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private ToolStripMenuItem toolStripMenuItemSetFont;
        private ToolStripSeparator toolStripSeparator6;
    }
}
