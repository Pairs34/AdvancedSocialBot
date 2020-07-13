namespace AdvancedSocialBot
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.backTask = new System.ComponentModel.BackgroundWorker();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProfileManager = new DevExpress.XtraBars.BarButtonItem();
            this.btnStartJob = new DevExpress.XtraBars.BarButtonItem();
            this.btnStopJob = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.activeUsersList = new DevExpress.XtraBars.BarEditItem();
            this.cbActiveUsersList = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnRefreshActiveUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnInitActiveUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoteSupport = new DevExpress.XtraBars.BarButtonItem();
            this.btnYTSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnActiveDebug = new DevExpress.XtraBars.BarEditItem();
            this.cbIsDebugger = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.lblLicenseOwner = new DevExpress.XtraBars.BarHeaderItem();
            this.txtLicenseOwner = new DevExpress.XtraBars.BarStaticItem();
            this.lblTotalChannels = new DevExpress.XtraBars.BarHeaderItem();
            this.txtTotalChannels = new DevExpress.XtraBars.BarStaticItem();
            this.blTotalChannels = new DevExpress.XtraBars.BarStaticItem();
            this.lblUsedChannelsCount = new DevExpress.XtraBars.BarStaticItem();
            this.txtLicenseDetail = new DevExpress.XtraBars.BarHeaderItem();
            this.btnUnFollow = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.pageYoutube = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageYoutubeMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageYoutubeSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txtUsedChannelsCount = new DevExpress.XtraBars.BarStaticItem();
            this.lstLog = new System.Windows.Forms.ListView();
            this.clAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clChannel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clYTUri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActiveUsersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsDebugger)).BeginInit();
            this.SuspendLayout();
            // 
            // backTask
            // 
            this.backTask.WorkerSupportsCancellation = true;
            this.backTask.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backTask_DoWork);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnProfileManager,
            this.btnStartJob,
            this.btnStopJob,
            this.btnAbout,
            this.activeUsersList,
            this.btnRefreshActiveUsers,
            this.btnInitActiveUser,
            this.btnRemoteSupport,
            this.btnYTSettings,
            this.btnActiveDebug,
            this.lblLicenseOwner,
            this.txtLicenseOwner,
            this.lblTotalChannels,
            this.txtTotalChannels,
            this.blTotalChannels,
            this.lblUsedChannelsCount,
            this.txtLicenseDetail,
            this.btnUnFollow,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 28;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.txtLicenseDetail);
            this.ribbonControl.PageHeaderItemLinks.Add(this.btnActiveDebug);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageYoutube});
            this.ribbonControl.QuickToolbarItemLinks.Add(this.btnAbout);
            this.ribbonControl.QuickToolbarItemLinks.Add(this.activeUsersList);
            this.ribbonControl.QuickToolbarItemLinks.Add(this.btnRefreshActiveUsers);
            this.ribbonControl.QuickToolbarItemLinks.Add(this.btnInitActiveUser);
            this.ribbonControl.QuickToolbarItemLinks.Add(this.btnRemoteSupport);
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbActiveUsersList,
            this.cbIsDebugger});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(734, 181);
            this.ribbonControl.StatusBar = this.statusBar;
            // 
            // btnProfileManager
            // 
            this.btnProfileManager.Caption = "Profil Ayarları";
            this.btnProfileManager.Hint = "Profiller Ekleyebilir veya Silebilirsiniz";
            this.btnProfileManager.Id = 1;
            this.btnProfileManager.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProfileManager.ImageOptions.SvgImage")));
            this.btnProfileManager.Name = "btnProfileManager";
            this.btnProfileManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProfileManager_ItemClick);
            // 
            // btnStartJob
            // 
            this.btnStartJob.Caption = "Başlat";
            this.btnStartJob.Hint = "Abone İşlemlerini Başlat";
            this.btnStartJob.Id = 2;
            this.btnStartJob.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStartJob.ImageOptions.SvgImage")));
            this.btnStartJob.Name = "btnStartJob";
            this.btnStartJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStartJob_ItemClick);
            // 
            // btnStopJob
            // 
            this.btnStopJob.Caption = "Durdur";
            this.btnStopJob.Hint = "İşlemleri Sonlandır";
            this.btnStopJob.Id = 3;
            this.btnStopJob.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStopJob.ImageOptions.SvgImage")));
            this.btnStopJob.Name = "btnStopJob";
            this.btnStopJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStopJob_ItemClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "Hakkında";
            this.btnAbout.Hint = "Hakkımızda";
            this.btnAbout.Id = 4;
            this.btnAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.Image")));
            this.btnAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.LargeImage")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // activeUsersList
            // 
            this.activeUsersList.Caption = "Aktif Profil Listesi";
            this.activeUsersList.Edit = this.cbActiveUsersList;
            this.activeUsersList.EditWidth = 120;
            this.activeUsersList.Hint = "Eklenen YT Profilleri";
            this.activeUsersList.Id = 5;
            this.activeUsersList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("activeUsersList.ImageOptions.Image")));
            this.activeUsersList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("activeUsersList.ImageOptions.LargeImage")));
            this.activeUsersList.Name = "activeUsersList";
            this.activeUsersList.EditValueChanged += new System.EventHandler(this.activeUsersList_EditValueChanged);
            // 
            // cbActiveUsersList
            // 
            this.cbActiveUsersList.AutoHeight = false;
            this.cbActiveUsersList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbActiveUsersList.Name = "cbActiveUsersList";
            this.cbActiveUsersList.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // btnRefreshActiveUsers
            // 
            this.btnRefreshActiveUsers.Id = 6;
            this.btnRefreshActiveUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshActiveUsers.ImageOptions.Image")));
            this.btnRefreshActiveUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshActiveUsers.ImageOptions.LargeImage")));
            this.btnRefreshActiveUsers.Name = "btnRefreshActiveUsers";
            this.btnRefreshActiveUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshActiveUsers_ItemClick);
            // 
            // btnInitActiveUser
            // 
            this.btnInitActiveUser.Id = 7;
            this.btnInitActiveUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInitActiveUser.ImageOptions.Image")));
            this.btnInitActiveUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInitActiveUser.ImageOptions.LargeImage")));
            this.btnInitActiveUser.Name = "btnInitActiveUser";
            this.btnInitActiveUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInitActiveUser_ItemClick);
            // 
            // btnRemoteSupport
            // 
            this.btnRemoteSupport.Hint = "Uzak Yardım";
            this.btnRemoteSupport.Id = 8;
            this.btnRemoteSupport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoteSupport.ImageOptions.Image")));
            this.btnRemoteSupport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemoteSupport.ImageOptions.LargeImage")));
            this.btnRemoteSupport.Name = "btnRemoteSupport";
            // 
            // btnYTSettings
            // 
            this.btnYTSettings.Caption = "Çalışma Zamanı Ayarları";
            this.btnYTSettings.Id = 9;
            this.btnYTSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYTSettings.ImageOptions.SvgImage")));
            this.btnYTSettings.Name = "btnYTSettings";
            this.btnYTSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYTSettings_ItemClick);
            // 
            // btnActiveDebug
            // 
            this.btnActiveDebug.Caption = "Hata Ayıklama";
            this.btnActiveDebug.Edit = this.cbIsDebugger;
            this.btnActiveDebug.Id = 11;
            this.btnActiveDebug.Name = "btnActiveDebug";
            // 
            // cbIsDebugger
            // 
            this.cbIsDebugger.AutoHeight = false;
            this.cbIsDebugger.LookAndFeel.SkinName = "The Bezier";
            this.cbIsDebugger.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cbIsDebugger.Name = "cbIsDebugger";
            this.cbIsDebugger.OffText = "Pasif";
            this.cbIsDebugger.OnText = "Aktif";
            // 
            // lblLicenseOwner
            // 
            this.lblLicenseOwner.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicenseOwner.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lblLicenseOwner.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLicenseOwner.Appearance.Options.UseFont = true;
            this.lblLicenseOwner.Appearance.Options.UseForeColor = true;
            this.lblLicenseOwner.Appearance.Options.UseTextOptions = true;
            this.lblLicenseOwner.Caption = "Lisans Sahibi";
            this.lblLicenseOwner.Id = 12;
            this.lblLicenseOwner.Name = "lblLicenseOwner";
            // 
            // txtLicenseOwner
            // 
            this.txtLicenseOwner.Caption = "...";
            this.txtLicenseOwner.Id = 13;
            this.txtLicenseOwner.Name = "txtLicenseOwner";
            // 
            // lblTotalChannels
            // 
            this.lblTotalChannels.Caption = "Toplam Kanal Sayısı";
            this.lblTotalChannels.Id = 14;
            this.lblTotalChannels.Name = "lblTotalChannels";
            // 
            // txtTotalChannels
            // 
            this.txtTotalChannels.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtTotalChannels.Caption = "0";
            this.txtTotalChannels.Id = 15;
            this.txtTotalChannels.Name = "txtTotalChannels";
            // 
            // blTotalChannels
            // 
            this.blTotalChannels.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.blTotalChannels.Caption = "Çekilen Kanal Sayısı";
            this.blTotalChannels.Id = 21;
            this.blTotalChannels.Name = "blTotalChannels";
            // 
            // lblUsedChannelsCount
            // 
            this.lblUsedChannelsCount.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblUsedChannelsCount.Caption = "Kullanılan Kanal Sayısı";
            this.lblUsedChannelsCount.Id = 22;
            this.lblUsedChannelsCount.Name = "lblUsedChannelsCount";
            // 
            // txtLicenseDetail
            // 
            this.txtLicenseDetail.Caption = "...";
            this.txtLicenseDetail.Id = 23;
            this.txtLicenseDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtLicenseDetail.ImageOptions.Image")));
            this.txtLicenseDetail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("txtLicenseDetail.ImageOptions.LargeImage")));
            this.txtLicenseDetail.Name = "txtLicenseDetail";
            // 
            // btnUnFollow
            // 
            this.btnUnFollow.Caption = "UnFollower";
            this.btnUnFollow.Id = 24;
            this.btnUnFollow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnFollow.ImageOptions.Image")));
            this.btnUnFollow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUnFollow.ImageOptions.LargeImage")));
            this.btnUnFollow.Name = "btnUnFollow";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Youtube Watcher";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Id = 25;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Video Manager";
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Id = 26;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // pageYoutube
            // 
            this.pageYoutube.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageYoutubeMain,
            this.pageYoutubeSettings});
            this.pageYoutube.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pageYoutube.ImageOptions.Image")));
            this.pageYoutube.Name = "pageYoutube";
            this.pageYoutube.Text = "Youtube";
            // 
            // pageYoutubeMain
            // 
            this.pageYoutubeMain.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pageYoutubeMain.ItemLinks.Add(this.btnProfileManager);
            this.pageYoutubeMain.ItemLinks.Add(this.btnStartJob);
            this.pageYoutubeMain.ItemLinks.Add(this.btnStopJob);
            this.pageYoutubeMain.Name = "pageYoutubeMain";
            this.pageYoutubeMain.Text = "Youtube Anasayfa";
            // 
            // pageYoutubeSettings
            // 
            this.pageYoutubeSettings.ItemLinks.Add(this.btnYTSettings);
            this.pageYoutubeSettings.Name = "pageYoutubeSettings";
            this.pageYoutubeSettings.Text = "Youtube Ayarları";
            // 
            // statusBar
            // 
            this.statusBar.ItemLinks.Add(this.lblLicenseOwner);
            this.statusBar.ItemLinks.Add(this.txtLicenseOwner);
            this.statusBar.ItemLinks.Add(this.blTotalChannels);
            this.statusBar.ItemLinks.Add(this.txtTotalChannels);
            this.statusBar.ItemLinks.Add(this.lblUsedChannelsCount);
            this.statusBar.ItemLinks.Add(this.txtUsedChannelsCount);
            this.statusBar.Location = new System.Drawing.Point(0, 467);
            this.statusBar.Name = "statusBar";
            this.statusBar.Ribbon = this.ribbonControl;
            this.statusBar.Size = new System.Drawing.Size(734, 26);
            // 
            // txtUsedChannelsCount
            // 
            this.txtUsedChannelsCount.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtUsedChannelsCount.Caption = "0";
            this.txtUsedChannelsCount.Id = 18;
            this.txtUsedChannelsCount.Name = "txtUsedChannelsCount";
            // 
            // lstLog
            // 
            this.lstLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clAction,
            this.clChannel,
            this.clYTUri});
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.FullRowSelect = true;
            this.lstLog.HideSelection = false;
            this.lstLog.Location = new System.Drawing.Point(0, 181);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(734, 286);
            this.lstLog.TabIndex = 8;
            this.lstLog.UseCompatibleStateImageBehavior = false;
            this.lstLog.View = System.Windows.Forms.View.Details;
            // 
            // clAction
            // 
            this.clAction.Text = "İşlem";
            this.clAction.Width = 368;
            // 
            // clChannel
            // 
            this.clChannel.Text = "Kanal Adı";
            this.clChannel.Width = 123;
            // 
            // clYTUri
            // 
            this.clYTUri.Text = "YT Uri";
            this.clYTUri.Width = 213;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 181);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(734, 312);
            this.fluentDesignFormContainer1.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 493);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::AdvancedSocialBot.Properties.Resources.youtube_512px;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.statusBar;
            this.Text = "Advanced Social Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActiveUsersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsDebugger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backTask;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageYoutube;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageYoutubeMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageYoutubeSettings;
        private DevExpress.XtraBars.BarButtonItem btnProfileManager;
        private DevExpress.XtraBars.BarButtonItem btnStartJob;
        private DevExpress.XtraBars.BarButtonItem btnStopJob;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.BarEditItem activeUsersList;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbActiveUsersList;
        private DevExpress.XtraBars.BarButtonItem btnRefreshActiveUsers;
        private DevExpress.XtraBars.BarButtonItem btnInitActiveUser;
        private DevExpress.XtraBars.BarButtonItem btnRemoteSupport;
        private DevExpress.XtraBars.BarButtonItem btnYTSettings;
        private DevExpress.XtraBars.BarEditItem btnActiveDebug;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch cbIsDebugger;
        private DevExpress.XtraBars.BarHeaderItem lblLicenseOwner;
        private DevExpress.XtraBars.BarStaticItem txtLicenseOwner;
        private DevExpress.XtraBars.BarHeaderItem lblTotalChannels;
        private DevExpress.XtraBars.BarStaticItem txtTotalChannels;
        private DevExpress.XtraBars.BarStaticItem txtUsedChannelsCount;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar statusBar;
        private DevExpress.XtraBars.BarStaticItem blTotalChannels;
        private DevExpress.XtraBars.BarStaticItem lblUsedChannelsCount;
        private System.Windows.Forms.ListView lstLog;
        private System.Windows.Forms.ColumnHeader clAction;
        private System.Windows.Forms.ColumnHeader clChannel;
        private System.Windows.Forms.ColumnHeader clYTUri;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.BarHeaderItem txtLicenseDetail;
        private DevExpress.XtraBars.BarButtonItem btnUnFollow;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}

