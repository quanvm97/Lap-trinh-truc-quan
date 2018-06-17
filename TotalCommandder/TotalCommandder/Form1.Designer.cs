namespace TotalCommandder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPack = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnPack = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.chkOneScreen = new DevExpress.XtraBars.BarCheckItem();
            this.chkTwoScreen = new DevExpress.XtraBars.BarCheckItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnCut = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaste = new DevExpress.XtraBars.BarButtonItem();
            this.btnRename = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnNoneSelect = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarSubItem();
            this.btnRecycleDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPermanentlyDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotepad = new DevExpress.XtraBars.BarButtonItem();
            this.btnFind = new DevExpress.XtraBars.BarButtonItem();
            this.btnReviewFind = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Group2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnPack,
            this.btnUnPack,
            this.skinRibbonGalleryBarItem1,
            this.chkOneScreen,
            this.chkTwoScreen,
            this.btnCopy,
            this.btnCut,
            this.btnPaste,
            this.btnRename,
            this.btnSelectAll,
            this.btnNoneSelect,
            this.btnDelete,
            this.btnRecycleDelete,
            this.btnPermanentlyDelete,
            this.btnNotepad,
            this.btnFind,
            this.btnReviewFind});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 28;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1179, 102);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnPack
            // 
            this.btnPack.Caption = "Packing";
            this.btnPack.Id = 1;
            this.btnPack.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.packIcon;
            this.btnPack.Name = "btnPack";
            this.btnPack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPack_ItemClick);
            // 
            // btnUnPack
            // 
            this.btnUnPack.Caption = "UnPacking";
            this.btnUnPack.Id = 2;
            this.btnUnPack.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.unpackIcon;
            this.btnUnPack.Name = "btnUnPack";
            this.btnUnPack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnPack_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 4;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // chkOneScreen
            // 
            this.chkOneScreen.Caption = "One Screen";
            this.chkOneScreen.Id = 7;
            this.chkOneScreen.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.oneScreenIcon;
            this.chkOneScreen.Name = "chkOneScreen";
            this.chkOneScreen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.chkOneScreen_ItemClick);
            // 
            // chkTwoScreen
            // 
            this.chkTwoScreen.BindableChecked = true;
            this.chkTwoScreen.Caption = "Two Screen";
            this.chkTwoScreen.Checked = true;
            this.chkTwoScreen.Id = 8;
            this.chkTwoScreen.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.twoScreenIcon;
            this.chkTwoScreen.Name = "chkTwoScreen";
            this.chkTwoScreen.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkTwoScreen_CheckedChanged);
            this.chkTwoScreen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.chkTwoScreen_ItemClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "Copy";
            this.btnCopy.Enabled = false;
            this.btnCopy.Id = 1;
            this.btnCopy.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.copy_32x32;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // btnCut
            // 
            this.btnCut.Caption = "Cut";
            this.btnCut.Enabled = false;
            this.btnCut.Id = 2;
            this.btnCut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCut.ImageOptions.LargeImage")));
            this.btnCut.Name = "btnCut";
            this.btnCut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCut_ItemClick);
            // 
            // btnPaste
            // 
            this.btnPaste.Caption = "Paste";
            this.btnPaste.Enabled = false;
            this.btnPaste.Id = 3;
            this.btnPaste.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.paste_32x32;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPaste_ItemClick);
            // 
            // btnRename
            // 
            this.btnRename.Caption = "Rename";
            this.btnRename.Enabled = false;
            this.btnRename.Id = 5;
            this.btnRename.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.rename;
            this.btnRename.Name = "btnRename";
            this.btnRename.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRename_ItemClick);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Caption = "Select All";
            this.btnSelectAll.Id = 6;
            this.btnSelectAll.ImageOptions.Image = global::TotalCommandder.Properties.Resources.selecttable_32x32;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelectAll_ItemClick);
            // 
            // btnNoneSelect
            // 
            this.btnNoneSelect.Caption = "None Select";
            this.btnNoneSelect.Id = 7;
            this.btnNoneSelect.ImageOptions.Image = global::TotalCommandder.Properties.Resources.no_border_32x32;
            this.btnNoneSelect.Name = "btnNoneSelect";
            this.btnNoneSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNoneSelect_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Enabled = false;
            this.btnDelete.Id = 13;
            this.btnDelete.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.cancel_32x32;
            this.btnDelete.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRecycleDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPermanentlyDelete)});
            this.btnDelete.Name = "btnDelete";
            // 
            // btnRecycleDelete
            // 
            this.btnRecycleDelete.Caption = "Recycle";
            this.btnRecycleDelete.Id = 14;
            this.btnRecycleDelete.ImageOptions.Image = global::TotalCommandder.Properties.Resources.recycleBinIcon;
            this.btnRecycleDelete.Name = "btnRecycleDelete";
            this.btnRecycleDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecycleDelete_ItemClick);
            // 
            // btnPermanentlyDelete
            // 
            this.btnPermanentlyDelete.Caption = "Permanently Delete";
            this.btnPermanentlyDelete.Id = 15;
            this.btnPermanentlyDelete.ImageOptions.Image = global::TotalCommandder.Properties.Resources.delete_16x16;
            this.btnPermanentlyDelete.Name = "btnPermanentlyDelete";
            this.btnPermanentlyDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPermanentlyDelete_ItemClick);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Caption = "Notepad";
            this.btnNotepad.Id = 16;
            this.btnNotepad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotepad.ImageOptions.LargeImage")));
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotepad_ItemClick);
            // 
            // btnFind
            // 
            this.btnFind.Caption = "Find";
            this.btnFind.Id = 23;
            this.btnFind.ImageOptions.LargeImage = global::TotalCommandder.Properties.Resources.find_32x32;
            this.btnFind.Name = "btnFind";
            this.btnFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFind_ItemClick);
            // 
            // btnReviewFind
            // 
            this.btnReviewFind.Caption = "Review Find";
            this.btnReviewFind.Enabled = false;
            this.btnReviewFind.Id = 24;
            this.btnReviewFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReviewFind.ImageOptions.Image")));
            this.btnReviewFind.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReviewFind.ImageOptions.LargeImage")));
            this.btnReviewFind.Name = "btnReviewFind";
            this.btnReviewFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReviewFind_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Group2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // Group2
            // 
            this.Group2.ItemLinks.Add(this.chkOneScreen);
            this.Group2.ItemLinks.Add(this.chkTwoScreen);
            this.Group2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.Group2.ItemLinks.Add(this.btnCopy, true);
            this.Group2.ItemLinks.Add(this.btnCut);
            this.Group2.ItemLinks.Add(this.btnPaste);
            this.Group2.ItemLinks.Add(this.btnDelete, true);
            this.Group2.ItemLinks.Add(this.btnRename);
            this.Group2.ItemLinks.Add(this.btnFind, true);
            this.Group2.ItemLinks.Add(this.btnReviewFind);
            this.Group2.ItemLinks.Add(this.btnPack, true);
            this.Group2.ItemLinks.Add(this.btnUnPack);
            this.Group2.ItemLinks.Add(this.btnNotepad);
            this.Group2.ItemLinks.Add(this.btnSelectAll, true);
            this.Group2.ItemLinks.Add(this.btnNoneSelect);
            this.Group2.Name = "Group2";
            this.Group2.ShowCaptionButton = false;
            this.Group2.Text = "View";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1179, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel6.Text = "Enter Open";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "F2 Rename";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel2.Text = "Ctrl+C Copy";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel3.Text = "Ctrl+X Cut";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel4.Text = "Ctrl+V Paste";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel5.Text = "Ctrl+N New Folder";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(174, 17);
            this.toolStripStatusLabel7.Text = "Delete -> Delete Items";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 102);
            this.splitMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitMain.Name = "splitMain";
            this.splitMain.Size = new System.Drawing.Size(1179, 504);
            this.splitMain.SplitterDistance = 589;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 628);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Total Commander";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btnPack;
        private DevExpress.XtraBars.BarButtonItem btnUnPack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private System.Windows.Forms.SplitContainer splitMain;
        private DevExpress.XtraBars.BarCheckItem chkOneScreen;
        private DevExpress.XtraBars.BarCheckItem chkTwoScreen;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnCut;
        private DevExpress.XtraBars.BarButtonItem btnPaste;
        private DevExpress.XtraBars.BarButtonItem btnRename;
        private DevExpress.XtraBars.BarButtonItem btnSelectAll;
        private DevExpress.XtraBars.BarButtonItem btnNoneSelect;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarSubItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRecycleDelete;
        private DevExpress.XtraBars.BarButtonItem btnPermanentlyDelete;
        private DevExpress.XtraBars.BarButtonItem btnNotepad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Group2;
        private DevExpress.XtraBars.BarButtonItem btnFind;
        private DevExpress.XtraBars.BarButtonItem btnReviewFind;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
    }
}
