namespace YoutubeOrganicBot
{
    partial class frmYTSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTSettings));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.tabControllerSettings = new DevExpress.XtraTab.XtraTabControl();
            this.tabChannels = new DevExpress.XtraTab.XtraTabPage();
            this.grpChannels = new DevExpress.XtraEditors.GroupControl();
            this.lstChannels = new DevExpress.XtraEditors.ListBoxControl();
            this.channelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteChFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddChToList = new DevExpress.XtraEditors.SimpleButton();
            this.txtChannelUri = new DevExpress.XtraEditors.TextEdit();
            this.tabComments = new DevExpress.XtraTab.XtraTabPage();
            this.grpComments = new DevExpress.XtraEditors.GroupControl();
            this.lstComments = new DevExpress.XtraEditors.ListBoxControl();
            this.commentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCommentFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCommentToList = new DevExpress.XtraEditors.SimpleButton();
            this.txtComment = new DevExpress.XtraEditors.TextEdit();
            this.tabTimeSettings = new DevExpress.XtraTab.XtraTabPage();
            this.grpCustomSettings = new DevExpress.XtraEditors.GroupControl();
            this.txtPreCaption = new DevExpress.XtraEditors.TextEdit();
            this.lblPreCaption = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRandomWaitMax = new DevExpress.XtraEditors.TextEdit();
            this.txtRandomWaitMin = new DevExpress.XtraEditors.TextEdit();
            this.lblRandomWaitMinMax = new System.Windows.Forms.Label();
            this.txtVideoWatchMax = new DevExpress.XtraEditors.TextEdit();
            this.txtVideoWatchMin = new DevExpress.XtraEditors.TextEdit();
            this.lblVideoWatchMinMax = new System.Windows.Forms.Label();
            this.txtAfterVideoWaitMax = new DevExpress.XtraEditors.TextEdit();
            this.txtAfterVideoWaitMin = new DevExpress.XtraEditors.TextEdit();
            this.lblAfterVideoWaitMinMax = new System.Windows.Forms.Label();
            this.IsCustomTextActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.tabUsedChannels = new DevExpress.XtraTab.XtraTabPage();
            this.grpUsedChannels = new DevExpress.XtraEditors.GroupControl();
            this.lstUsedChannel = new DevExpress.XtraEditors.ListBoxControl();
            this.btnSaveYTSettings = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControllerSettings)).BeginInit();
            this.tabControllerSettings.SuspendLayout();
            this.tabChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpChannels)).BeginInit();
            this.grpChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstChannels)).BeginInit();
            this.channelContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChannelUri.Properties)).BeginInit();
            this.tabComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpComments)).BeginInit();
            this.grpComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstComments)).BeginInit();
            this.commentContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).BeginInit();
            this.tabTimeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomSettings)).BeginInit();
            this.grpCustomSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandomWaitMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandomWaitMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVideoWatchMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVideoWatchMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterVideoWaitMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterVideoWaitMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsCustomTextActive.Properties)).BeginInit();
            this.tabUsedChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpUsedChannels)).BeginInit();
            this.grpUsedChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstUsedChannel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControllerSettings
            // 
            this.tabControllerSettings.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tabControllerSettings.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tabControllerSettings.Location = new System.Drawing.Point(7, 10);
            this.tabControllerSettings.Name = "tabControllerSettings";
            this.tabControllerSettings.SelectedTabPage = this.tabChannels;
            this.tabControllerSettings.Size = new System.Drawing.Size(782, 300);
            this.tabControllerSettings.TabIndex = 11;
            this.tabControllerSettings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabChannels,
            this.tabComments,
            this.tabTimeSettings,
            this.tabUsedChannels});
            // 
            // tabChannels
            // 
            this.tabChannels.Controls.Add(this.grpChannels);
            this.tabChannels.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabChannels.ImageOptions.Image")));
            this.tabChannels.Name = "tabChannels";
            this.tabChannels.Size = new System.Drawing.Size(656, 296);
            this.tabChannels.Text = "Kanal Ayarları";
            // 
            // grpChannels
            // 
            this.grpChannels.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpChannels.CaptionImageOptions.SvgImage")));
            this.grpChannels.Controls.Add(this.lstChannels);
            this.grpChannels.Controls.Add(this.btnAddChToList);
            this.grpChannels.Controls.Add(this.txtChannelUri);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            this.grpChannels.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Oto Doldur", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "btnAutoFillChannel", -1)});
            this.grpChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChannels.Location = new System.Drawing.Point(0, 0);
            this.grpChannels.Name = "grpChannels";
            this.grpChannels.Size = new System.Drawing.Size(656, 296);
            this.grpChannels.TabIndex = 7;
            this.grpChannels.Text = "Kanallar";
            this.grpChannels.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.grpChannels_CustomButtonClick);
            // 
            // lstChannels
            // 
            this.lstChannels.ContextMenuStrip = this.channelContextMenu;
            this.lstChannels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstChannels.Location = new System.Drawing.Point(2, 74);
            this.lstChannels.Name = "lstChannels";
            this.lstChannels.Size = new System.Drawing.Size(652, 220);
            this.lstChannels.TabIndex = 2;
            this.lstChannels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstChannels_KeyDown);
            // 
            // channelContextMenu
            // 
            this.channelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteChFromList});
            this.channelContextMenu.Name = "channelContextMenu";
            this.channelContextMenu.Size = new System.Drawing.Size(87, 26);
            // 
            // deleteChFromList
            // 
            this.deleteChFromList.Name = "deleteChFromList";
            this.deleteChFromList.Size = new System.Drawing.Size(86, 22);
            this.deleteChFromList.Text = "Sil";
            this.deleteChFromList.Click += new System.EventHandler(this.deleteChFromList_Click);
            // 
            // btnAddChToList
            // 
            this.btnAddChToList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddChToList.ImageOptions.Image")));
            this.btnAddChToList.Location = new System.Drawing.Point(251, 42);
            this.btnAddChToList.Name = "btnAddChToList";
            this.btnAddChToList.Size = new System.Drawing.Size(48, 23);
            this.btnAddChToList.TabIndex = 1;
            this.btnAddChToList.Text = "Ekle";
            this.btnAddChToList.Click += new System.EventHandler(this.btnAddChToList_Click);
            // 
            // txtChannelUri
            // 
            this.txtChannelUri.Location = new System.Drawing.Point(6, 43);
            this.txtChannelUri.Name = "txtChannelUri";
            this.txtChannelUri.Properties.NullValuePrompt = "Kanal urlsini yazınız";
            this.txtChannelUri.Size = new System.Drawing.Size(239, 20);
            this.txtChannelUri.TabIndex = 0;
            this.txtChannelUri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChannelUri_KeyDown);
            // 
            // tabComments
            // 
            this.tabComments.Controls.Add(this.grpComments);
            this.tabComments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabComments.ImageOptions.Image")));
            this.tabComments.Name = "tabComments";
            this.tabComments.Size = new System.Drawing.Size(656, 296);
            this.tabComments.Text = "Yorum Ayarları";
            // 
            // grpComments
            // 
            this.grpComments.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpComments.CaptionImageOptions.Image")));
            this.grpComments.Controls.Add(this.lstComments);
            this.grpComments.Controls.Add(this.btnAddCommentToList);
            this.grpComments.Controls.Add(this.txtComment);
            buttonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonImageOptions2.SvgImage")));
            this.grpComments.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Oto Doldur", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "btnAutoFillComments", -1)});
            this.grpComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpComments.Location = new System.Drawing.Point(0, 0);
            this.grpComments.Name = "grpComments";
            this.grpComments.Size = new System.Drawing.Size(656, 296);
            this.grpComments.TabIndex = 8;
            this.grpComments.Text = "Yorumlar";
            this.grpComments.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.grpComments_CustomButtonClick);
            // 
            // lstComments
            // 
            this.lstComments.ContextMenuStrip = this.commentContextMenu;
            this.lstComments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstComments.ItemAutoHeight = true;
            this.lstComments.Location = new System.Drawing.Point(2, 74);
            this.lstComments.Name = "lstComments";
            this.lstComments.Size = new System.Drawing.Size(652, 220);
            this.lstComments.TabIndex = 2;
            this.lstComments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstComments_KeyDown);
            // 
            // commentContextMenu
            // 
            this.commentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCommentFromList});
            this.commentContextMenu.Name = "commentContextMenu";
            this.commentContextMenu.Size = new System.Drawing.Size(87, 26);
            // 
            // deleteCommentFromList
            // 
            this.deleteCommentFromList.Name = "deleteCommentFromList";
            this.deleteCommentFromList.Size = new System.Drawing.Size(86, 22);
            this.deleteCommentFromList.Text = "Sil";
            this.deleteCommentFromList.Click += new System.EventHandler(this.deleteCommentFromList_Click);
            // 
            // btnAddCommentToList
            // 
            this.btnAddCommentToList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCommentToList.ImageOptions.Image")));
            this.btnAddCommentToList.Location = new System.Drawing.Point(251, 42);
            this.btnAddCommentToList.Name = "btnAddCommentToList";
            this.btnAddCommentToList.Size = new System.Drawing.Size(48, 23);
            this.btnAddCommentToList.TabIndex = 1;
            this.btnAddCommentToList.Text = "Ekle";
            this.btnAddCommentToList.Click += new System.EventHandler(this.btnAddCommentToList_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(6, 43);
            this.txtComment.Name = "txtComment";
            this.txtComment.Properties.NullValuePrompt = "Yorum yazınız";
            this.txtComment.Size = new System.Drawing.Size(239, 20);
            this.txtComment.TabIndex = 0;
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment_KeyDown);
            // 
            // tabTimeSettings
            // 
            this.tabTimeSettings.Controls.Add(this.grpCustomSettings);
            this.tabTimeSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabTimeSettings.ImageOptions.Image")));
            this.tabTimeSettings.Name = "tabTimeSettings";
            this.tabTimeSettings.Size = new System.Drawing.Size(656, 296);
            this.tabTimeSettings.Text = "Zaman Ayarları";
            // 
            // grpCustomSettings
            // 
            this.grpCustomSettings.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpCustomSettings.CaptionImageOptions.SvgImage")));
            this.grpCustomSettings.Controls.Add(this.txtPreCaption);
            this.grpCustomSettings.Controls.Add(this.lblPreCaption);
            this.grpCustomSettings.Controls.Add(this.labelControl1);
            this.grpCustomSettings.Controls.Add(this.txtRandomWaitMax);
            this.grpCustomSettings.Controls.Add(this.txtRandomWaitMin);
            this.grpCustomSettings.Controls.Add(this.lblRandomWaitMinMax);
            this.grpCustomSettings.Controls.Add(this.txtVideoWatchMax);
            this.grpCustomSettings.Controls.Add(this.txtVideoWatchMin);
            this.grpCustomSettings.Controls.Add(this.lblVideoWatchMinMax);
            this.grpCustomSettings.Controls.Add(this.txtAfterVideoWaitMax);
            this.grpCustomSettings.Controls.Add(this.txtAfterVideoWaitMin);
            this.grpCustomSettings.Controls.Add(this.lblAfterVideoWaitMinMax);
            this.grpCustomSettings.Controls.Add(this.IsCustomTextActive);
            this.grpCustomSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomSettings.Location = new System.Drawing.Point(0, 0);
            this.grpCustomSettings.Name = "grpCustomSettings";
            this.grpCustomSettings.Size = new System.Drawing.Size(656, 296);
            this.grpCustomSettings.TabIndex = 10;
            this.grpCustomSettings.Text = "Bazı Özel Ayarlar";
            // 
            // txtPreCaption
            // 
            this.txtPreCaption.Location = new System.Drawing.Point(54, 134);
            this.txtPreCaption.Name = "txtPreCaption";
            this.txtPreCaption.Properties.NullText = "Yorumdan önceki kelime. Örn: Özlü Söz , AtaSözü gibi";
            this.txtPreCaption.Properties.NullValuePrompt = "Yorumdan önceki kelime. Örn: Özlü Söz , AtaSözü gibi";
            this.txtPreCaption.Size = new System.Drawing.Size(347, 20);
            this.txtPreCaption.TabIndex = 13;
            // 
            // lblPreCaption
            // 
            this.lblPreCaption.AutoSize = true;
            this.lblPreCaption.Location = new System.Drawing.Point(5, 137);
            this.lblPreCaption.Name = "lblPreCaption";
            this.lblPreCaption.Size = new System.Drawing.Size(43, 13);
            this.lblPreCaption.TabIndex = 12;
            this.lblPreCaption.Text = "Ön Yazı";
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 161);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(429, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "<b><color=\'red\'>Önemli = </color> Bekleme süreleri mili saniye cinsindendir\r\n Örn" +
    " : 1000 = 1 saniye dir.</b>";
            // 
            // txtRandomWaitMax
            // 
            this.txtRandomWaitMax.Location = new System.Drawing.Point(325, 102);
            this.txtRandomWaitMax.Name = "txtRandomWaitMax";
            this.txtRandomWaitMax.Properties.NullValuePrompt = "5000";
            this.txtRandomWaitMax.Size = new System.Drawing.Size(76, 20);
            this.txtRandomWaitMax.TabIndex = 10;
            // 
            // txtRandomWaitMin
            // 
            this.txtRandomWaitMin.Location = new System.Drawing.Point(224, 102);
            this.txtRandomWaitMin.Name = "txtRandomWaitMin";
            this.txtRandomWaitMin.Properties.NullValuePrompt = "3000";
            this.txtRandomWaitMin.Size = new System.Drawing.Size(76, 20);
            this.txtRandomWaitMin.TabIndex = 9;
            // 
            // lblRandomWaitMinMax
            // 
            this.lblRandomWaitMinMax.AutoSize = true;
            this.lblRandomWaitMinMax.Location = new System.Drawing.Point(242, 86);
            this.lblRandomWaitMinMax.Name = "lblRandomWaitMinMax";
            this.lblRandomWaitMinMax.Size = new System.Drawing.Size(137, 13);
            this.lblRandomWaitMinMax.TabIndex = 8;
            this.lblRandomWaitMinMax.Text = "Rastgele Bekleme Min. Max";
            // 
            // txtVideoWatchMax
            // 
            this.txtVideoWatchMax.Location = new System.Drawing.Point(106, 102);
            this.txtVideoWatchMax.Name = "txtVideoWatchMax";
            this.txtVideoWatchMax.Properties.NullValuePrompt = "95000";
            this.txtVideoWatchMax.Size = new System.Drawing.Size(76, 20);
            this.txtVideoWatchMax.TabIndex = 7;
            // 
            // txtVideoWatchMin
            // 
            this.txtVideoWatchMin.Location = new System.Drawing.Point(5, 102);
            this.txtVideoWatchMin.Name = "txtVideoWatchMin";
            this.txtVideoWatchMin.Properties.NullValuePrompt = "75000";
            this.txtVideoWatchMin.Size = new System.Drawing.Size(76, 20);
            this.txtVideoWatchMin.TabIndex = 6;
            // 
            // lblVideoWatchMinMax
            // 
            this.lblVideoWatchMinMax.AutoSize = true;
            this.lblVideoWatchMinMax.Location = new System.Drawing.Point(23, 86);
            this.lblVideoWatchMinMax.Name = "lblVideoWatchMinMax";
            this.lblVideoWatchMinMax.Size = new System.Drawing.Size(113, 13);
            this.lblVideoWatchMinMax.TabIndex = 5;
            this.lblVideoWatchMinMax.Text = "Video İzleme Min. Max";
            // 
            // txtAfterVideoWaitMax
            // 
            this.txtAfterVideoWaitMax.Location = new System.Drawing.Point(106, 60);
            this.txtAfterVideoWaitMax.Name = "txtAfterVideoWaitMax";
            this.txtAfterVideoWaitMax.Properties.NullValuePrompt = "240000";
            this.txtAfterVideoWaitMax.Size = new System.Drawing.Size(76, 20);
            this.txtAfterVideoWaitMax.TabIndex = 4;
            // 
            // txtAfterVideoWaitMin
            // 
            this.txtAfterVideoWaitMin.Location = new System.Drawing.Point(5, 60);
            this.txtAfterVideoWaitMin.Name = "txtAfterVideoWaitMin";
            this.txtAfterVideoWaitMin.Properties.NullValuePrompt = "180000";
            this.txtAfterVideoWaitMin.Size = new System.Drawing.Size(76, 20);
            this.txtAfterVideoWaitMin.TabIndex = 2;
            // 
            // lblAfterVideoWaitMinMax
            // 
            this.lblAfterVideoWaitMinMax.AutoSize = true;
            this.lblAfterVideoWaitMinMax.Location = new System.Drawing.Point(5, 44);
            this.lblAfterVideoWaitMinMax.Name = "lblAfterVideoWaitMinMax";
            this.lblAfterVideoWaitMinMax.Size = new System.Drawing.Size(177, 13);
            this.lblAfterVideoWaitMinMax.TabIndex = 1;
            this.lblAfterVideoWaitMinMax.Text = "Videodan Sonraki Min. Max Bekleme";
            // 
            // IsCustomTextActive
            // 
            this.IsCustomTextActive.Location = new System.Drawing.Point(224, 42);
            this.IsCustomTextActive.Name = "IsCustomTextActive";
            this.IsCustomTextActive.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.IsCustomTextActive.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.IsCustomTextActive.Properties.OffText = "Yorumlara Ek Söz Ekleme";
            this.IsCustomTextActive.Properties.OnText = "Yorumlara Ek Söz Ekle";
            this.IsCustomTextActive.Size = new System.Drawing.Size(197, 24);
            this.IsCustomTextActive.TabIndex = 0;
            // 
            // tabUsedChannels
            // 
            this.tabUsedChannels.Controls.Add(this.grpUsedChannels);
            this.tabUsedChannels.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabUsedChannels.ImageOptions.Image")));
            this.tabUsedChannels.Name = "tabUsedChannels";
            this.tabUsedChannels.Size = new System.Drawing.Size(656, 296);
            this.tabUsedChannels.Text = "Geçmiş Kanallar";
            // 
            // grpUsedChannels
            // 
            this.grpUsedChannels.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpUsedChannels.CaptionImageOptions.SvgImage")));
            this.grpUsedChannels.Controls.Add(this.lstUsedChannel);
            this.grpUsedChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUsedChannels.Location = new System.Drawing.Point(0, 0);
            this.grpUsedChannels.Name = "grpUsedChannels";
            this.grpUsedChannels.Size = new System.Drawing.Size(656, 296);
            this.grpUsedChannels.TabIndex = 9;
            this.grpUsedChannels.Text = "İşlem Gören Kanallar";
            // 
            // lstUsedChannel
            // 
            this.lstUsedChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsedChannel.Location = new System.Drawing.Point(2, 39);
            this.lstUsedChannel.Name = "lstUsedChannel";
            this.lstUsedChannel.Size = new System.Drawing.Size(652, 255);
            this.lstUsedChannel.TabIndex = 2;
            // 
            // btnSaveYTSettings
            // 
            this.btnSaveYTSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveYTSettings.ImageOptions.SvgImage")));
            this.btnSaveYTSettings.Location = new System.Drawing.Point(687, 316);
            this.btnSaveYTSettings.Name = "btnSaveYTSettings";
            this.btnSaveYTSettings.Size = new System.Drawing.Size(102, 41);
            this.btnSaveYTSettings.TabIndex = 12;
            this.btnSaveYTSettings.Text = "Kaydet";
            this.btnSaveYTSettings.Click += new System.EventHandler(this.btnSaveYTSettings_Click);
            // 
            // frmYTSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 361);
            this.Controls.Add(this.btnSaveYTSettings);
            this.Controls.Add(this.tabControllerSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYTSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YT Settings";
            this.Load += new System.EventHandler(this.frmYTSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControllerSettings)).EndInit();
            this.tabControllerSettings.ResumeLayout(false);
            this.tabChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpChannels)).EndInit();
            this.grpChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstChannels)).EndInit();
            this.channelContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtChannelUri.Properties)).EndInit();
            this.tabComments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpComments)).EndInit();
            this.grpComments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstComments)).EndInit();
            this.commentContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).EndInit();
            this.tabTimeSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomSettings)).EndInit();
            this.grpCustomSettings.ResumeLayout(false);
            this.grpCustomSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandomWaitMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandomWaitMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVideoWatchMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVideoWatchMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterVideoWaitMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterVideoWaitMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsCustomTextActive.Properties)).EndInit();
            this.tabUsedChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpUsedChannels)).EndInit();
            this.grpUsedChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstUsedChannel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControllerSettings;
        private DevExpress.XtraTab.XtraTabPage tabChannels;
        private DevExpress.XtraEditors.GroupControl grpChannels;
        private DevExpress.XtraEditors.SimpleButton btnAddChToList;
        private DevExpress.XtraEditors.TextEdit txtChannelUri;
        private DevExpress.XtraTab.XtraTabPage tabComments;
        private DevExpress.XtraEditors.GroupControl grpComments;
        private DevExpress.XtraEditors.ListBoxControl lstComments;
        private DevExpress.XtraEditors.SimpleButton btnAddCommentToList;
        private DevExpress.XtraEditors.TextEdit txtComment;
        private DevExpress.XtraTab.XtraTabPage tabTimeSettings;
        private DevExpress.XtraEditors.GroupControl grpCustomSettings;
        private DevExpress.XtraEditors.TextEdit txtPreCaption;
        private System.Windows.Forms.Label lblPreCaption;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRandomWaitMax;
        private DevExpress.XtraEditors.TextEdit txtRandomWaitMin;
        private System.Windows.Forms.Label lblRandomWaitMinMax;
        private DevExpress.XtraEditors.TextEdit txtVideoWatchMax;
        private DevExpress.XtraEditors.TextEdit txtVideoWatchMin;
        private System.Windows.Forms.Label lblVideoWatchMinMax;
        private DevExpress.XtraEditors.TextEdit txtAfterVideoWaitMax;
        private DevExpress.XtraEditors.TextEdit txtAfterVideoWaitMin;
        private System.Windows.Forms.Label lblAfterVideoWaitMinMax;
        private DevExpress.XtraEditors.ToggleSwitch IsCustomTextActive;
        private DevExpress.XtraEditors.SimpleButton btnSaveYTSettings;
        private System.Windows.Forms.ContextMenuStrip channelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteChFromList;
        private System.Windows.Forms.ContextMenuStrip commentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteCommentFromList;
        public DevExpress.XtraEditors.ListBoxControl lstChannels;
        private DevExpress.XtraTab.XtraTabPage tabUsedChannels;
        private DevExpress.XtraEditors.GroupControl grpUsedChannels;
        private DevExpress.XtraEditors.ListBoxControl lstUsedChannel;
    }
}