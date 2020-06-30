namespace YoutubeOrganicBot
{
    partial class frmProfileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfileManager));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.grpCreateUserProfile = new DevExpress.XtraEditors.GroupControl();
            this.btnCreateProfile = new DevExpress.XtraEditors.SimpleButton();
            this.txtProfileName = new DevExpress.XtraEditors.TextEdit();
            this.grpUserList = new DevExpress.XtraEditors.GroupControl();
            this.lstUserList = new DevExpress.XtraEditors.ListBoxControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grpCreateUserProfile)).BeginInit();
            this.grpCreateUserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUserList)).BeginInit();
            this.grpUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstUserList)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreateUserProfile
            // 
            this.grpCreateUserProfile.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpCreateUserProfile.CaptionImageOptions.Image")));
            this.grpCreateUserProfile.Controls.Add(this.btnCreateProfile);
            this.grpCreateUserProfile.Controls.Add(this.txtProfileName);
            this.grpCreateUserProfile.Location = new System.Drawing.Point(12, 12);
            this.grpCreateUserProfile.Name = "grpCreateUserProfile";
            this.grpCreateUserProfile.Size = new System.Drawing.Size(255, 116);
            this.grpCreateUserProfile.TabIndex = 0;
            this.grpCreateUserProfile.Text = "Profil Oluştur";
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateProfile.ImageOptions.Image")));
            this.btnCreateProfile.Location = new System.Drawing.Point(75, 68);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(93, 40);
            this.btnCreateProfile.TabIndex = 1;
            this.btnCreateProfile.Text = "Kaydet";
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(6, 42);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Properties.NullValuePrompt = "Profil Adı Giriniz";
            this.txtProfileName.Size = new System.Drawing.Size(242, 20);
            this.txtProfileName.TabIndex = 0;
            this.txtProfileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProfileName_KeyDown);
            // 
            // grpUserList
            // 
            this.grpUserList.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpUserList.CaptionImageOptions.Image")));
            this.grpUserList.Controls.Add(this.lstUserList);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            this.grpUserList.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Yenile", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "btnRefreshProfiles", -1)});
            this.grpUserList.Location = new System.Drawing.Point(273, 12);
            this.grpUserList.Margin = new System.Windows.Forms.Padding(10);
            this.grpUserList.Name = "grpUserList";
            this.grpUserList.Size = new System.Drawing.Size(255, 301);
            this.grpUserList.TabIndex = 1;
            this.grpUserList.Text = "Profil Listesi";
            this.grpUserList.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.grpUserList_CustomButtonClick);
            // 
            // lstUserList
            // 
            this.lstUserList.ContextMenuStrip = this.contextMenu;
            this.lstUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUserList.Location = new System.Drawing.Point(2, 39);
            this.lstUserList.Margin = new System.Windows.Forms.Padding(8);
            this.lstUserList.Name = "lstUserList";
            this.lstUserList.Padding = new System.Windows.Forms.Padding(8);
            this.lstUserList.Size = new System.Drawing.Size(251, 260);
            this.lstUserList.TabIndex = 0;
            this.lstUserList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstUserList_KeyDown);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // frmProfileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 316);
            this.Controls.Add(this.grpUserList);
            this.Controls.Add(this.grpCreateUserProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProfileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Manager";
            this.Load += new System.EventHandler(this.frmProfileManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpCreateUserProfile)).EndInit();
            this.grpCreateUserProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProfileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUserList)).EndInit();
            this.grpUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstUserList)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCreateUserProfile;
        private DevExpress.XtraEditors.TextEdit txtProfileName;
        private DevExpress.XtraEditors.SimpleButton btnCreateProfile;
        private DevExpress.XtraEditors.GroupControl grpUserList;
        private DevExpress.XtraEditors.ListBoxControl lstUserList;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}