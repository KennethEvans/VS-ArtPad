using System.Windows.Forms;

namespace ArtPad {
    partial class KeyButton {

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
            this.toolStripMenuItemAppearance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTroubleshooting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSendHoldKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemResetTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemApplicationNotTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripMenuItemTroubleshooting,
            this.toolStripSeparator5,
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSaveAs,
            this.toolStripSeparator4,
            this.toolStripMenuItemHelp});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(414, 390);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // toolStripMenuItemEditKey
            // 
            this.toolStripMenuItemEditKey.Name = "toolStripMenuItemEditKey";
            this.toolStripMenuItemEditKey.Size = new System.Drawing.Size(413, 46);
            this.toolStripMenuItemEditKey.Text = "Edit Key...";
            this.toolStripMenuItemEditKey.ToolTipText = "Edit this key.";
            // 
            // toolStripMenuItemCopyKey
            // 
            this.toolStripMenuItemCopyKey.Name = "toolStripMenuItemCopyKey";
            this.toolStripMenuItemCopyKey.Size = new System.Drawing.Size(413, 46);
            this.toolStripMenuItemCopyKey.Text = "Copy Key";
            this.toolStripMenuItemCopyKey.ToolTipText = "Copy the definition for this key to the clipboard.";
            // 
            // toolStripMenuItemPasteKey
            // 
            this.toolStripMenuItemPasteKey.Name = "toolStripMenuItemPasteKey";
            this.toolStripMenuItemPasteKey.Size = new System.Drawing.Size(413, 46);
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
            this.toolStripMenuItemAppearance,
            this.toolStripMenuItemSort,
            this.toolStripSeparator6,
            this.toolStripMenuItemCreateNew});
            this.toolStripMenuItemEditKeys.Name = "toolStripMenuItemEditKeys";
            this.toolStripMenuItemEditKeys.Size = new System.Drawing.Size(413, 46);
            this.toolStripMenuItemEditKeys.Text = "Edit Key Configuration...";
            this.toolStripMenuItemEditKeys.ToolTipText = "Edit the key configuration.";
            // 
            // toolStripMenuItemDeleteRow
            // 
            this.toolStripMenuItemDeleteRow.Name = "toolStripMenuItemDeleteRow";
            this.toolStripMenuItemDeleteRow.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemDeleteRow.Text = "Delete Row";
            this.toolStripMenuItemDeleteRow.ToolTipText = "Delete this row.";
            // 
            // toolStripMenuItemAddRowBefore
            // 
            this.toolStripMenuItemAddRowBefore.Name = "toolStripMenuItemAddRowBefore";
            this.toolStripMenuItemAddRowBefore.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemAddRowBefore.Text = "Add Row Before";
            this.toolStripMenuItemAddRowBefore.ToolTipText = "Add a row before this one.";
            // 
            // toolStripMenuItemAddRowAfter
            // 
            this.toolStripMenuItemAddRowAfter.Name = "toolStripMenuItemAddRowAfter";
            this.toolStripMenuItemAddRowAfter.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemAddRowAfter.Text = "Add Row After";
            this.toolStripMenuItemAddRowAfter.ToolTipText = "Add a row after this one.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(494, 6);
            // 
            // toolStripMenuItemDeleteCol
            // 
            this.toolStripMenuItemDeleteCol.Name = "toolStripMenuItemDeleteCol";
            this.toolStripMenuItemDeleteCol.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemDeleteCol.Text = "Delete Column";
            this.toolStripMenuItemDeleteCol.ToolTipText = "Delete this column.";
            // 
            // toolStripMenuItemAddColBefore
            // 
            this.toolStripMenuItemAddColBefore.Name = "toolStripMenuItemAddColBefore";
            this.toolStripMenuItemAddColBefore.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemAddColBefore.Text = "Add Column Before";
            this.toolStripMenuItemAddColBefore.ToolTipText = "Add a column before this one.";
            // 
            // toolStripMenuItemAddColAfter
            // 
            this.toolStripMenuItemAddColAfter.Name = "toolStripMenuItemAddColAfter";
            this.toolStripMenuItemAddColAfter.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemAddColAfter.Text = "Add Column After";
            this.toolStripMenuItemAddColAfter.ToolTipText = "Add a column after this one.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(494, 6);
            // 
            // toolStripMenuItemAppearance
            // 
            this.toolStripMenuItemAppearance.Name = "toolStripMenuItemAppearance";
            this.toolStripMenuItemAppearance.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemAppearance.Text = "Appearance...";
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemSort.Text = "Sort";
            this.toolStripMenuItemSort.ToolTipText = "Sort the key configuration list.";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(494, 6);
            // 
            // toolStripMenuItemCreateNew
            // 
            this.toolStripMenuItemCreateNew.Name = "toolStripMenuItemCreateNew";
            this.toolStripMenuItemCreateNew.Size = new System.Drawing.Size(497, 46);
            this.toolStripMenuItemCreateNew.Text = "Create New Configuration...";
            this.toolStripMenuItemCreateNew.ToolTipText = "Create a new key configuration .";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(410, 6);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(413, 46);
            this.toolStripMenuItemLoad.Text = "Load Configuration...";
            this.toolStripMenuItemLoad.ToolTipText = "Load a new configuration file.";
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(413, 46);
            this.toolStripMenuItemSaveAs.Text = "Save Configuration As...";
            this.toolStripMenuItemSaveAs.ToolTipText = "Save the current configuration.";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(410, 6);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOverview,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(413, 46);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemOverview
            // 
            this.toolStripMenuItemOverview.Name = "toolStripMenuItemOverview";
            this.toolStripMenuItemOverview.Size = new System.Drawing.Size(275, 46);
            this.toolStripMenuItemOverview.Text = "Overview...";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(275, 46);
            this.toolStripMenuItemAbout.Text = "About...";
            // 
            // toolStripMenuItemTroubleshooting
            // 
            this.toolStripMenuItemTroubleshooting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSendHoldKeys,
            this.toolStripMenuItemResetTopmost,
            this.toolStripMenuItemApplicationNotTopmost});
            this.toolStripMenuItemTroubleshooting.Name = "toolStripMenuItemTroubleshooting";
            this.toolStripMenuItemTroubleshooting.Size = new System.Drawing.Size(413, 46);
            this.toolStripMenuItemTroubleshooting.Text = "Troubleshooting";
            this.toolStripMenuItemTroubleshooting.ToolTipText = "Things to try when something goes wrong.";
            // 
            // toolStripMenuItemSendHoldKeys
            // 
            this.toolStripMenuItemSendHoldKeys.Name = "toolStripMenuItemSendHoldKeys";
            this.toolStripMenuItemSendHoldKeys.Size = new System.Drawing.Size(509, 46);
            this.toolStripMenuItemSendHoldKeys.Text = "Send Hold Keys Up";
            this.toolStripMenuItemSendHoldKeys.ToolTipText = "Sends up events for all hold keys.  (Mix fix application that is in a bad state.)" +
    "";
            this.toolStripMenuItemSendHoldKeys.Click += new System.EventHandler(this.toolStripMenuItemHoldKeysUp_click);
            // 
            // toolStripMenuItemResetTopmost
            // 
            this.toolStripMenuItemResetTopmost.Name = "toolStripMenuItemResetTopmost";
            this.toolStripMenuItemResetTopmost.Size = new System.Drawing.Size(509, 46);
            this.toolStripMenuItemResetTopmost.Text = "Reset ArtPad as Topmost";
            this.toolStripMenuItemResetTopmost.ToolTipText = "Resets ArtPad to be a Topmost application.";
            this.toolStripMenuItemResetTopmost.Click += new System.EventHandler(this.toolStripMenuItemArtPadTopmost_click);
            // 
            // toolStripMenuItemApplicationNotTopmost
            // 
            this.toolStripMenuItemApplicationNotTopmost.Name = "toolStripMenuItemApplicationNotTopmost";
            this.toolStripMenuItemApplicationNotTopmost.Size = new System.Drawing.Size(509, 46);
            this.toolStripMenuItemApplicationNotTopmost.Text = "Set Application not Topmost";
            this.toolStripMenuItemApplicationNotTopmost.ToolTipText = "Sets the associated foreground application to not be Topmost (thus possible on to" +
    "p of ArtPad.)";
            this.toolStripMenuItemApplicationNotTopmost.Click += new System.EventHandler(this.toolStripAsMenuItemApplicationNotTopmost_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(410, 6);
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
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItemCopyKey;
        private ToolStripMenuItem toolStripMenuItemPasteKey;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemOverview;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private ToolStripMenuItem toolStripMenuItemAppearance;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem toolStripMenuItemTroubleshooting;
        private ToolStripMenuItem toolStripMenuItemSendHoldKeys;
        private ToolStripMenuItem toolStripMenuItemResetTopmost;
        private ToolStripMenuItem toolStripMenuItemApplicationNotTopmost;
        private ToolStripSeparator toolStripSeparator5;
    }
}
