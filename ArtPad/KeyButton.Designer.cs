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
            this.toolStripMenuItemEditKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddRowBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddRowAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteCol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddColBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddColAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditKey,
            this.toolStripMenuItemEditKeys,
            this.toolStripSeparator1,
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSaveAs});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(243, 114);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // toolStripMenuItemEditKey
            // 
            this.toolStripMenuItemEditKey.Name = "toolStripMenuItemEditKey";
            this.toolStripMenuItemEditKey.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemEditKey.Text = "Edit Key...";
            this.toolStripMenuItemEditKey.ToolTipText = "Edit this key.";
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
            this.toolStripMenuItemSort,
            this.toolStripMenuItemCreateNew});
            this.toolStripMenuItemEditKeys.Name = "toolStripMenuItemEditKeys";
            this.toolStripMenuItemEditKeys.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemEditKeys.Text = "Edit Key Configuration...";
            this.toolStripMenuItemEditKeys.ToolTipText = "Edit the key configuration.";
            // 
            // toolStripMenuItemDeleteRow
            // 
            this.toolStripMenuItemDeleteRow.Name = "toolStripMenuItemDeleteRow";
            this.toolStripMenuItemDeleteRow.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemDeleteRow.Text = "Delete Row";
            this.toolStripMenuItemDeleteRow.ToolTipText = "Delete this row.";
            // 
            // toolStripMenuItemAddRowBefore
            // 
            this.toolStripMenuItemAddRowBefore.Name = "toolStripMenuItemAddRowBefore";
            this.toolStripMenuItemAddRowBefore.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemAddRowBefore.Text = "Add Row Before";
            this.toolStripMenuItemAddRowBefore.ToolTipText = "Add a row before this one.";
            // 
            // toolStripMenuItemAddRowAfter
            // 
            this.toolStripMenuItemAddRowAfter.Name = "toolStripMenuItemAddRowAfter";
            this.toolStripMenuItemAddRowAfter.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemAddRowAfter.Text = "Add Row After";
            this.toolStripMenuItemAddRowAfter.ToolTipText = "Add a row after this one.";
            // 
            // toolStripMenuItemDeleteCol
            // 
            this.toolStripMenuItemDeleteCol.Name = "toolStripMenuItemDeleteCol";
            this.toolStripMenuItemDeleteCol.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemDeleteCol.Text = "Delete Column";
            this.toolStripMenuItemDeleteCol.ToolTipText = "Delete this column.";
            // 
            // toolStripMenuItemAddColBefore
            // 
            this.toolStripMenuItemAddColBefore.Name = "toolStripMenuItemAddColBefore";
            this.toolStripMenuItemAddColBefore.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemAddColBefore.Text = "Add Column Before";
            this.toolStripMenuItemAddColBefore.ToolTipText = "Add a column before this one.";
            // 
            // toolStripMenuItemAddColAfter
            // 
            this.toolStripMenuItemAddColAfter.Name = "toolStripMenuItemAddColAfter";
            this.toolStripMenuItemAddColAfter.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemAddColAfter.Text = "Add Column After";
            this.toolStripMenuItemAddColAfter.ToolTipText = "Add a column after this one.";
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemSort.Text = "Sort";
            this.toolStripMenuItemSort.ToolTipText = "Sort the key configuration list.";
            // 
            // toolStripMenuItemCreateNew
            // 
            this.toolStripMenuItemCreateNew.Name = "toolStripMenuItemCreateNew";
            this.toolStripMenuItemCreateNew.Size = new System.Drawing.Size(265, 26);
            this.toolStripMenuItemCreateNew.Text = "Create New Configuration...";
            this.toolStripMenuItemCreateNew.ToolTipText = "Create a new key configuration .";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemLoad.Text = "Load Configuration...";
            this.toolStripMenuItemLoad.ToolTipText = "Load a new configuration file.";
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemSaveAs.Text = "Save Configuration As...";
            this.toolStripMenuItemSaveAs.ToolTipText = "Save the current configuration.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
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
    }
}
