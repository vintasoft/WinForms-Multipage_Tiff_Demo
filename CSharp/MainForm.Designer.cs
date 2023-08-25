namespace MultiPageTiffDemo
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertPagesBeforeCurrentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertPagesAfterCurrentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.metadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageLoadingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageLoadingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imagesEncodingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagesEncodingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imageEncodingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageEncodingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imageInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openTiffFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTiffFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.openAllImagesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.viewerToolStrip = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.toolStripSeparator4,
            this.packToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newFileToolStripMenuItem.Text = "New...";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveFileAsToolStripMenuItem.Text = "Save as...";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.closeFileToolStripMenuItem.Text = "Close";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.packToolStripMenuItem.Text = "Pack";
            this.packToolStripMenuItem.Click += new System.EventHandler(this.packToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerImageToolStripMenuItem,
            this.imageViewerSettingsToolStripMenuItem,
            this.colorManagementToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // centerImageToolStripMenuItem
            // 
            this.centerImageToolStripMenuItem.CheckOnClick = true;
            this.centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            this.centerImageToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.centerImageToolStripMenuItem.Text = "Center Image";
            this.centerImageToolStripMenuItem.Click += new System.EventHandler(this.centerImageToolStripMenuItem_Click);
            // 
            // imageViewerSettingsToolStripMenuItem
            // 
            this.imageViewerSettingsToolStripMenuItem.Name = "imageViewerSettingsToolStripMenuItem";
            this.imageViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.imageViewerSettingsToolStripMenuItem.Text = "Image Viewer Settings...";
            this.imageViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageViewerSettingsToolStripMenuItem_Click);
            // 
            // colorManagementToolStripMenuItem
            // 
            this.colorManagementToolStripMenuItem.Name = "colorManagementToolStripMenuItem";
            this.colorManagementToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.colorManagementToolStripMenuItem.Text = "Color Management...";
            this.colorManagementToolStripMenuItem.Click += new System.EventHandler(this.colorManagementToolStripMenuItem_Click);
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPagesToolStripMenuItem,
            this.insertPagesBeforeCurrentPageToolStripMenuItem,
            this.insertPagesAfterCurrentPageToolStripMenuItem,
            this.removePageToolStripMenuItem,
            this.toolStripSeparator9,
            this.metadataToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // addPagesToolStripMenuItem
            // 
            this.addPagesToolStripMenuItem.Name = "addPagesToolStripMenuItem";
            this.addPagesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addPagesToolStripMenuItem.Text = "Add Pages...";
            this.addPagesToolStripMenuItem.Click += new System.EventHandler(this.addPagesToolStripMenuItem_Click);
            // 
            // insertPagesBeforeCurrentPageToolStripMenuItem
            // 
            this.insertPagesBeforeCurrentPageToolStripMenuItem.Name = "insertPagesBeforeCurrentPageToolStripMenuItem";
            this.insertPagesBeforeCurrentPageToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insertPagesBeforeCurrentPageToolStripMenuItem.Text = "Insert Pages Before...";
            this.insertPagesBeforeCurrentPageToolStripMenuItem.Click += new System.EventHandler(this.insertPagesBeforeCurrentPageToolStripMenuItem_Click);
            // 
            // insertPagesAfterCurrentPageToolStripMenuItem
            // 
            this.insertPagesAfterCurrentPageToolStripMenuItem.Name = "insertPagesAfterCurrentPageToolStripMenuItem";
            this.insertPagesAfterCurrentPageToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insertPagesAfterCurrentPageToolStripMenuItem.Text = "Insert Pages After...";
            this.insertPagesAfterCurrentPageToolStripMenuItem.Click += new System.EventHandler(this.insertPagesAfterCurrentPageToolStripMenuItem_Click);
            // 
            // removePageToolStripMenuItem
            // 
            this.removePageToolStripMenuItem.Name = "removePageToolStripMenuItem";
            this.removePageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removePageToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.removePageToolStripMenuItem.Text = "Remove Current Page";
            this.removePageToolStripMenuItem.Click += new System.EventHandler(this.removePageToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(210, 6);
            // 
            // metadataToolStripMenuItem
            // 
            this.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem";
            this.metadataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.metadataToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.metadataToolStripMenuItem.Text = "Page Metadata...";
            this.metadataToolStripMenuItem.Click += new System.EventHandler(this.metadataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressStatus,
            this.imageLoadingProgressBarLabel,
            this.imageLoadingProgressBar,
            this.imagesEncodingProgressBarLabel,
            this.imagesEncodingProgressBar,
            this.imageEncodingProgressBarLabel,
            this.imageEncodingProgressBar,
            this.imageInfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressStatus
            // 
            this.toolStripProgressStatus.Name = "toolStripProgressStatus";
            this.toolStripProgressStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // imageLoadingProgressBarLabel
            // 
            this.imageLoadingProgressBarLabel.Name = "imageLoadingProgressBarLabel";
            this.imageLoadingProgressBarLabel.Size = new System.Drawing.Size(85, 17);
            this.imageLoadingProgressBarLabel.Text = "Loading page: ";
            this.imageLoadingProgressBarLabel.Visible = false;
            // 
            // imageLoadingProgressBar
            // 
            this.imageLoadingProgressBar.Name = "imageLoadingProgressBar";
            this.imageLoadingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imageLoadingProgressBar.Visible = false;
            // 
            // imagesEncodingProgressBarLabel
            // 
            this.imagesEncodingProgressBarLabel.Name = "imagesEncodingProgressBarLabel";
            this.imagesEncodingProgressBarLabel.Size = new System.Drawing.Size(101, 17);
            this.imagesEncodingProgressBarLabel.Text = "Encoding images:";
            this.imagesEncodingProgressBarLabel.Visible = false;
            // 
            // imagesEncodingProgressBar
            // 
            this.imagesEncodingProgressBar.Name = "imagesEncodingProgressBar";
            this.imagesEncodingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imagesEncodingProgressBar.Visible = false;
            // 
            // imageEncodingProgressBarLabel
            // 
            this.imageEncodingProgressBarLabel.Name = "imageEncodingProgressBarLabel";
            this.imageEncodingProgressBarLabel.Size = new System.Drawing.Size(96, 17);
            this.imageEncodingProgressBarLabel.Text = "Encoding image:";
            this.imageEncodingProgressBarLabel.Visible = false;
            // 
            // imageEncodingProgressBar
            // 
            this.imageEncodingProgressBar.Name = "imageEncodingProgressBar";
            this.imageEncodingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imageEncodingProgressBar.Visible = false;
            // 
            // imageInfoLabel
            // 
            this.imageInfoLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.imageInfoLabel.Name = "imageInfoLabel";
            this.imageInfoLabel.Size = new System.Drawing.Size(150, 17);
            this.imageInfoLabel.Spring = true;
            this.imageInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openTiffFileDialog
            // 
            this.openTiffFileDialog.Filter = "TIFF files|*.tif*;*.btf";
            // 
            // saveTiffFileDialog
            // 
            this.saveTiffFileDialog.DefaultExt = "tif";
            this.saveTiffFileDialog.Filter = "TIFF files(*.tif;*.tiff)|*.tif;*.tiff";
            this.saveTiffFileDialog.FilterIndex = 0;
            // 
            // imageViewer1
            // 
            this.imageViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageViewer1.AutoScroll = true;
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageViewer1.Location = new System.Drawing.Point(12, 64);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.ShortcutCopy = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.Size = new System.Drawing.Size(760, 464);
            this.imageViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.PixelToPixel;
            this.imageViewer1.TabIndex = 0;
            this.imageViewer1.Text = "imageViewer1";
            // 
            // openAllImagesFileDialog
            // 
            this.openAllImagesFileDialog.Multiselect = true;
            // 
            // viewerToolStrip
            // 
            this.viewerToolStrip.AssociatedZoomTrackBar = null;
            this.viewerToolStrip.CanPrint = false;
            this.viewerToolStrip.CanSaveFile = false;
            this.viewerToolStrip.ImageViewer = this.imageViewer1;
            this.viewerToolStrip.ScanButtonEnabled = true;
            this.viewerToolStrip.Location = new System.Drawing.Point(0, 24);
            this.viewerToolStrip.Name = "viewerToolStrip";
            this.viewerToolStrip.PageCount = 0;
            this.viewerToolStrip.PrintButtonEnabled = true;
            this.viewerToolStrip.SaveButtonEnabled = true;
            this.viewerToolStrip.Size = new System.Drawing.Size(784, 25);
            this.viewerToolStrip.TabIndex = 0;
            this.viewerToolStrip.Text = "imageViewerToolStripContainer";
            this.viewerToolStrip.UseImageViewerImages = false;
            this.viewerToolStrip.OpenFile += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.viewerToolStrip.PageIndexChanged += new System.EventHandler<DemosCommonCode.Imaging.PageIndexChangedEventArgs>(this.imageViewerToolStrip_PageIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imageViewer1);
            this.Controls.Add(this.viewerToolStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(607, 454);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Multipage TIFF Demo";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openTiffFileDialog;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addPagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertPagesBeforeCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertPagesAfterCurrentPageToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripProgressStatus;
        private System.Windows.Forms.ToolStripProgressBar imagesEncodingProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripStatusLabel imageInfoLabel;
		private System.Windows.Forms.ToolStripStatusLabel imagesEncodingProgressBarLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        private DemosCommonCode.Imaging.ImageViewerToolStrip viewerToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar imageLoadingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel imageLoadingProgressBarLabel;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveTiffFileDialog;
        private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel imageEncodingProgressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar imageEncodingProgressBar;
        private System.Windows.Forms.OpenFileDialog openAllImagesFileDialog;
        private System.Windows.Forms.ToolStripMenuItem colorManagementToolStripMenuItem;
	}
}
