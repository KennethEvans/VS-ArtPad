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
            this.toolStripMenuItemMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorControls = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripMenuItemTroubleshooting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowForegroundWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSendHoldKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemResetTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemApplicationNotTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemApplicationTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOverviewOnline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMove,
            this.toolStripMenuItemSize,
            this.toolStripMenuItemRestore,
            this.toolStripMenuItemMinimize,
            this.toolStripMenuItemMaximize,
            this.toolStripMenuItemExit,
            this.toolStripSeparatorControls,
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
            this.contextMenuStrip.Size = new System.Drawing.Size(414, 700);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // toolStripMenuItemMove
            // 
            this.toolStripMenuItemMove.Name = "toolStripMenuItemMove";
            this.toolStripMenuItemMove.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemMove.Text = "Toggle Move";
            this.toolStripMenuItemMove.Click += new System.EventHandler(this.toolStripMenuItemDoMove);
            // 
            // toolStripMenuItemSize
            // 
            this.toolStripMenuItemSize.Name = "toolStripMenuItemSize";
            this.toolStripMenuItemSize.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemSize.Text = "Toggle Size";
            this.toolStripMenuItemSize.Click += new System.EventHandler(this.toolStripMenuItemDoSize);
            // 
            // toolStripMenuItemRestore
            // 
            this.toolStripMenuItemRestore.Name = "toolStripMenuItemRestore";
            this.toolStripMenuItemRestore.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemRestore.Text = "Restore";
            this.toolStripMenuItemRestore.Click += new System.EventHandler(this.toolStripMenuItemDoRestore);
            // 
            // toolStripMenuItemMinimize
            // 
            this.toolStripMenuItemMinimize.Name = "toolStripMenuItemMinimize";
            this.toolStripMenuItemMinimize.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemMinimize.Text = "Minimize";
            this.toolStripMenuItemMinimize.Click += new System.EventHandler(this.toolStripMenuItemDoMimimize);
            // 
            // toolStripMenuItemMaximize
            // 
            this.toolStripMenuItemMaximize.Name = "toolStripMenuItemMaximize";
            this.toolStripMenuItemMaximize.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemMaximize.Text = "Maximize";
            this.toolStripMenuItemMaximize.Click += new System.EventHandler(this.toolStripMenuItemDoMaximize);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemDoExit);
            // 
            // toolStripSeparatorControls
            // 
            this.toolStripSeparatorControls.Name = "toolStripSeparatorControls";
            this.toolStripSeparatorControls.Size = new System.Drawing.Size(410, 6);
            // 
            // toolStripMenuItemEditKey
            // 
            this.toolStripMenuItemEditKey.Name = "toolStripMenuItemEditKey";
            this.toolStripMenuItemEditKey.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemEditKey.Text = "Edit Key...";
            this.toolStripMenuItemEditKey.ToolTipText = "Edit this key.";
            this.toolStripMenuItemEditKey.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemCopyKey
            // 
            this.toolStripMenuItemCopyKey.Name = "toolStripMenuItemCopyKey";
            this.toolStripMenuItemCopyKey.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemCopyKey.Text = "Copy Key";
            this.toolStripMenuItemCopyKey.ToolTipText = "Copy the definition for this key to the clipboard.";
            this.toolStripMenuItemCopyKey.Click += new System.EventHandler(this.toolStripMenuItemCopyKey_click);
            // 
            // toolStripMenuItemPasteKey
            // 
            this.toolStripMenuItemPasteKey.Name = "toolStripMenuItemPasteKey";
            this.toolStripMenuItemPasteKey.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemPasteKey.Text = "Paste Key";
            this.toolStripMenuItemPasteKey.ToolTipText = "Set the definition for this key from a key definition in the clipboard.";
            this.toolStripMenuItemPasteKey.Click += new System.EventHandler(this.toolStripMenuItemPasteKey_click);
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
            this.toolStripMenuItemEditKeys.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemEditKeys.Text = "Edit Key Configuration...";
            this.toolStripMenuItemEditKeys.ToolTipText = "Edit the key configuration.";
            // 
            // toolStripMenuItemDeleteRow
            // 
            this.toolStripMenuItemDeleteRow.Name = "toolStripMenuItemDeleteRow";
            this.toolStripMenuItemDeleteRow.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemDeleteRow.Text = "Delete Row";
            this.toolStripMenuItemDeleteRow.ToolTipText = "Delete this row.";
            this.toolStripMenuItemDeleteRow.Click += new System.EventHandler(this.toolStripMenuItemDeleteRow_click);
            // 
            // toolStripMenuItemAddRowBefore
            // 
            this.toolStripMenuItemAddRowBefore.Name = "toolStripMenuItemAddRowBefore";
            this.toolStripMenuItemAddRowBefore.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemAddRowBefore.Text = "Add Row Before";
            this.toolStripMenuItemAddRowBefore.ToolTipText = "Add a row before this one.";
            this.toolStripMenuItemAddRowBefore.Click += new System.EventHandler(this.toolStripMenuItemAddRowBefore_click);
            // 
            // toolStripMenuItemAddRowAfter
            // 
            this.toolStripMenuItemAddRowAfter.Name = "toolStripMenuItemAddRowAfter";
            this.toolStripMenuItemAddRowAfter.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemAddRowAfter.Text = "Add Row After";
            this.toolStripMenuItemAddRowAfter.ToolTipText = "Add a row after this one.";
            this.toolStripMenuItemAddRowAfter.Click += new System.EventHandler(this.toolStripMenuItemAddRowAfter_click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(546, 6);
            // 
            // toolStripMenuItemDeleteCol
            // 
            this.toolStripMenuItemDeleteCol.Name = "toolStripMenuItemDeleteCol";
            this.toolStripMenuItemDeleteCol.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemDeleteCol.Text = "Delete Column";
            this.toolStripMenuItemDeleteCol.ToolTipText = "Delete this column.";
            this.toolStripMenuItemDeleteCol.Click += new System.EventHandler(this.toolStripMenuItemDeleteCol_click);
            // 
            // toolStripMenuItemAddColBefore
            // 
            this.toolStripMenuItemAddColBefore.Name = "toolStripMenuItemAddColBefore";
            this.toolStripMenuItemAddColBefore.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemAddColBefore.Text = "Add Column Before";
            this.toolStripMenuItemAddColBefore.ToolTipText = "Add a column before this one.";
            this.toolStripMenuItemAddColBefore.Click += new System.EventHandler(this.toolStripMenuItemAddColBefore_click);
            // 
            // toolStripMenuItemAddColAfter
            // 
            this.toolStripMenuItemAddColAfter.Name = "toolStripMenuItemAddColAfter";
            this.toolStripMenuItemAddColAfter.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemAddColAfter.Text = "Add Column After";
            this.toolStripMenuItemAddColAfter.ToolTipText = "Add a column after this one.";
            this.toolStripMenuItemAddColAfter.Click += new System.EventHandler(this.toolStripMenuItemAddColAfter_click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(546, 6);
            // 
            // toolStripMenuItemAppearance
            // 
            this.toolStripMenuItemAppearance.Name = "toolStripMenuItemAppearance";
            this.toolStripMenuItemAppearance.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemAppearance.Text = "Appearance...";
            this.toolStripMenuItemAppearance.Click += new System.EventHandler(this.toolStripMenuItemAppearance_click);
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemSort.Text = "Sort";
            this.toolStripMenuItemSort.ToolTipText = "Sort the key configuration list.";
            this.toolStripMenuItemSort.Click += new System.EventHandler(this.toolStripMenuItemSort_click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(546, 6);
            // 
            // toolStripMenuItemCreateNew
            // 
            this.toolStripMenuItemCreateNew.Name = "toolStripMenuItemCreateNew";
            this.toolStripMenuItemCreateNew.Size = new System.Drawing.Size(549, 54);
            this.toolStripMenuItemCreateNew.Text = "Create New Configuration...";
            this.toolStripMenuItemCreateNew.ToolTipText = "Create a new key configuration .";
            this.toolStripMenuItemCreateNew.Click += new System.EventHandler(this.toolStripMenuItemCreateNew_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(410, 6);
            // 
            // toolStripMenuItemTroubleshooting
            // 
            this.toolStripMenuItemTroubleshooting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowForegroundWindow,
            this.toolStripMenuItemSendHoldKeys,
            this.toolStripMenuItemResetTopmost,
            this.toolStripMenuItemApplicationNotTopmost,
            this.toolStripMenuItemApplicationTopmost});
            this.toolStripMenuItemTroubleshooting.Name = "toolStripMenuItemTroubleshooting";
            this.toolStripMenuItemTroubleshooting.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemTroubleshooting.Text = "Troubleshooting";
            this.toolStripMenuItemTroubleshooting.ToolTipText = "Things to try when something goes wrong.";
            // 
            // toolStripMenuItemShowForegroundWindow
            // 
            this.toolStripMenuItemShowForegroundWindow.Name = "toolStripMenuItemShowForegroundWindow";
            this.toolStripMenuItemShowForegroundWindow.Size = new System.Drawing.Size(561, 54);
            this.toolStripMenuItemShowForegroundWindow.Text = "Show Foreground Window...";
            this.toolStripMenuItemShowForegroundWindow.ToolTipText = "Shows information about ArtPad and the current foreground window.";
            this.toolStripMenuItemShowForegroundWindow.Click += new System.EventHandler(this.toolStripMenuItemShowForegroundWin_Click);
            // 
            // toolStripMenuItemSendHoldKeys
            // 
            this.toolStripMenuItemSendHoldKeys.Name = "toolStripMenuItemSendHoldKeys";
            this.toolStripMenuItemSendHoldKeys.Size = new System.Drawing.Size(561, 54);
            this.toolStripMenuItemSendHoldKeys.Text = "Send Hold Keys Up";
            this.toolStripMenuItemSendHoldKeys.ToolTipText = "Sends up events for all hold keys.  (Mix fix application that is in a bad state.)" +
    "";
            this.toolStripMenuItemSendHoldKeys.Click += new System.EventHandler(this.toolStripMenuItemHoldKeysUp_click);
            // 
            // toolStripMenuItemResetTopmost
            // 
            this.toolStripMenuItemResetTopmost.Name = "toolStripMenuItemResetTopmost";
            this.toolStripMenuItemResetTopmost.Size = new System.Drawing.Size(561, 54);
            this.toolStripMenuItemResetTopmost.Text = "Reset ArtPad as Topmost";
            this.toolStripMenuItemResetTopmost.ToolTipText = "Resets ArtPad to be a Topmost application.";
            this.toolStripMenuItemResetTopmost.Click += new System.EventHandler(this.toolStripMenuItemArtPadTopmost_click);
            // 
            // toolStripMenuItemApplicationNotTopmost
            // 
            this.toolStripMenuItemApplicationNotTopmost.Name = "toolStripMenuItemApplicationNotTopmost";
            this.toolStripMenuItemApplicationNotTopmost.Size = new System.Drawing.Size(561, 54);
            this.toolStripMenuItemApplicationNotTopmost.Text = "Set Application not Topmost";
            this.toolStripMenuItemApplicationNotTopmost.ToolTipText = "Sets the associated foreground application to not be Topmost (thus not on top of " +
    "ArtPad.)";
            this.toolStripMenuItemApplicationNotTopmost.Click += new System.EventHandler(this.toolStripMenuItemApplicationNotTopmost_Click);
            // 
            // toolStripMenuItemApplicationTopmost
            // 
            this.toolStripMenuItemApplicationTopmost.Name = "toolStripMenuItemApplicationTopmost";
            this.toolStripMenuItemApplicationTopmost.Size = new System.Drawing.Size(561, 54);
            this.toolStripMenuItemApplicationTopmost.Text = "Set Application Topmost";
            this.toolStripMenuItemApplicationTopmost.ToolTipText = "Sets the associated foreground application to be Topmost (to correct setting the " +
    "wrong window not topmost.)";
            this.toolStripMenuItemApplicationTopmost.Click += new System.EventHandler(this.toolStripMenuItemApplicationTopmost_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(410, 6);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemLoad.Text = "Load Configuration...";
            this.toolStripMenuItemLoad.ToolTipText = "Load a new configuration file.";
            this.toolStripMenuItemLoad.Click += new System.EventHandler(this.toolStripMenuItemLoad_Click);
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemSaveAs.Text = "Save Configuration As...";
            this.toolStripMenuItemSaveAs.ToolTipText = "Save the current configuration.";
            this.toolStripMenuItemSaveAs.Click += new System.EventHandler(this.toolStripMenuItemSaveAs_Click);
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
            this.toolStripMenuItemOverviewOnline,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(413, 48);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemOverview
            // 
            this.toolStripMenuItemOverview.Name = "toolStripMenuItemOverview";
            this.toolStripMenuItemOverview.Size = new System.Drawing.Size(422, 54);
            this.toolStripMenuItemOverview.Text = "Overview...";
            this.toolStripMenuItemOverview.Click += new System.EventHandler(this.toolStripMenuItemOverview_click);
            // 
            // toolStripMenuItemOverviewOnline
            // 
            this.toolStripMenuItemOverviewOnline.Name = "toolStripMenuItemOverviewOnline";
            this.toolStripMenuItemOverviewOnline.Size = new System.Drawing.Size(422, 54);
            this.toolStripMenuItemOverviewOnline.Text = "Overview Online...";
            this.toolStripMenuItemOverviewOnline.Click += new System.EventHandler(this.toolStripMenuItemOverviewOnlineClick);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(422, 54);
            this.toolStripMenuItemAbout.Text = "About...";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_click);
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
        private ToolStripMenuItem toolStripMenuItemApplicationTopmost;
        private ToolStripMenuItem toolStripMenuItemShowForegroundWindow;
        private ToolStripMenuItem toolStripMenuItemOverviewOnline;
        private ToolStripMenuItem toolStripMenuItemMove;
        private ToolStripMenuItem toolStripMenuItemMinimize;
        private ToolStripMenuItem toolStripMenuItemMaximize;
        private ToolStripMenuItem toolStripMenuItemRestore;
        private ToolStripMenuItem toolStripMenuItemExit;
        private ToolStripSeparator toolStripSeparatorControls;
        private ToolStripMenuItem toolStripMenuItemSize;
    }
}
