using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.IO;
using AdvancedSocialBot.Helper;
using Newtonsoft.Json.Linq;
using System.Net;

namespace AdvancedSocialBot
{
    public partial class frmYTSettings : DevExpress.XtraEditors.XtraForm
    {       
        public frmYTSettings()
        {
            InitializeComponent();
        }

        private void btnSaveYTSettings_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"{Application.StartupPath}\\Profiles"))
            {
                Directory.CreateDirectory($"{Application.StartupPath}\\Profiles");
            }

            if (!File.Exists(YTGlobalSettings.CHANNELS_FILE_PATH))
                File.Create(YTGlobalSettings.CHANNELS_FILE_PATH).Close();

            if (!File.Exists(YTGlobalSettings.COMMENTS_FILE_PATH))
                File.Create(YTGlobalSettings.CHANNELS_FILE_PATH).Close();

            if (!File.Exists(YTGlobalSettings.USEDCHANNELS_FILE_PATH))
                File.Create(YTGlobalSettings.USEDCHANNELS_FILE_PATH).Close();

            try
            {
                File.WriteAllLines(YTGlobalSettings.CHANNELS_FILE_PATH, lstChannels.Items.Cast<string>());
                File.WriteAllLines(YTGlobalSettings.COMMENTS_FILE_PATH, lstComments.Items.Cast<string>());
                File.WriteAllLines(YTGlobalSettings.USEDCHANNELS_FILE_PATH, lstUsedChannel.Items.Cast<string>());

                Settings setting = new Settings()
                {
                    AfterVideoMinWait = Convert.ToInt32(txtAfterVideoWaitMin.Text),
                    AfterVideoMaxWait = Convert.ToInt32(txtAfterVideoWaitMax.Text),
                    IsCustomTextActive = IsCustomTextActive.IsOn,
                    RandomWaitMin = Convert.ToInt32(txtRandomWaitMin.Text),
                    RandomWaitMax = Convert.ToInt32(txtRandomWaitMax.Text),
                    WatchTimeMin = Convert.ToInt32(txtVideoWatchMin.Text),
                    WatchTimeMax = Convert.ToInt32(txtVideoWatchMax.Text),
                    PreCaption = txtPreCaption.Text,
                    RemoteServerUri = txtServerUri.Text,
                    IsActiveRemoteServer = swRemoteServer != null ? swRemoteServer.IsOn : false,
                    RemoteFFPath = txtFirefoxPath.Text
                };

                var json = JsonConvert.SerializeObject(setting);

                File.WriteAllText(YTGlobalSettings.SETTING_PATH, json);

                Console.WriteLine("Ayarlar kaydedildi.");

                LoadSettings();
            }
            catch (Exception err)
            {
                LogManager.LogToFile(err.StackTrace);
                MessageBox.Show($"Hata = {err.Message}");
            }
        }

        private void txtChannelUri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                lstChannels.Items.Add(txtChannelUri.Text);
                txtChannelUri.Text = string.Empty;
            }
        }

        private void btnAddChToList_Click(object sender, EventArgs e)
        {
            lstChannels.Items.Add(txtChannelUri.Text);
            txtChannelUri.Text = string.Empty;
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                lstComments.Items.Add(txtComment.Text);
                txtComment.Text = string.Empty;
            }
        }

        private void btnAddCommentToList_Click(object sender, EventArgs e)
        {
            lstComments.Items.Add(txtComment.Text);
            txtComment.Text = string.Empty;
        }

        private void deleteCommentFromList_Click(object sender, EventArgs e)
        {
            if (lstComments.SelectedIndex >= 0)
                lstComments.Items.RemoveAt(lstComments.SelectedIndex);
        }

        private void deleteChFromList_Click(object sender, EventArgs e)
        {
            if (lstChannels.SelectedIndex >= 0)
                lstChannels.Items.RemoveAt(lstChannels.SelectedIndex);
        }

        private void lstChannels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                if (lstChannels.SelectedIndex >= 0)
                {
                    lstChannels.Items.RemoveAt(lstChannels.SelectedIndex);
                }
            }
        }

        private void lstComments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                if (lstComments.SelectedIndex >= 0)
                {
                    lstComments.Items.RemoveAt(lstComments.SelectedIndex);
                }
            }
        }

        private void frmYTSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        public void LoadSettings()
        {
            if (File.Exists(YTGlobalSettings.CHANNELS_FILE_PATH) &&
                File.Exists(YTGlobalSettings.COMMENTS_FILE_PATH) &&
                File.Exists(YTGlobalSettings.USEDCHANNELS_FILE_PATH))
            {
                lstChannels.Items.Clear();
                lstComments.Items.Clear();
                lstUsedChannel.Items.Clear();

                var channels = File.ReadAllLines(YTGlobalSettings.CHANNELS_FILE_PATH);

                var comments = File.ReadAllLines(YTGlobalSettings.COMMENTS_FILE_PATH);

                var usedChannels = File.ReadAllLines(YTGlobalSettings.USEDCHANNELS_FILE_PATH);

                try
                {
                    foreach (var channel in channels)
                    {
                        lstChannels.Items.Add(channel);
                    }

                    foreach (var comment in comments)
                    {
                        lstComments.Items.Add(comment);
                    }

                    foreach (var usedChannel in usedChannels)
                    {
                        lstUsedChannel.Items.Add(usedChannel);
                    }
                }
                catch (Exception err)
                {
                    LogManager.LogToFile(err.StackTrace);
                    Console.WriteLine(err.Message);
                }

                if (File.Exists(YTGlobalSettings.SETTING_PATH))
                {
                    var strJson = File.ReadAllText(YTGlobalSettings.SETTING_PATH);
                    Settings settingTime = JsonConvert.DeserializeObject<Settings>(strJson);
                    txtAfterVideoWaitMin.Text = settingTime.AfterVideoMinWait.ToString();
                    txtAfterVideoWaitMax.Text = settingTime.AfterVideoMaxWait.ToString();
                    txtRandomWaitMin.Text = settingTime.RandomWaitMin.ToString();
                    txtRandomWaitMax.Text = settingTime.RandomWaitMax.ToString();
                    txtVideoWatchMin.Text = settingTime.WatchTimeMin.ToString();
                    txtVideoWatchMax.Text = settingTime.WatchTimeMax.ToString();
                    IsCustomTextActive.IsOn = settingTime.IsCustomTextActive;
                    txtPreCaption.Text = settingTime.PreCaption;
                    txtServerUri.Text = settingTime.RemoteServerUri;
                    swRemoteServer.IsOn = settingTime.IsActiveRemoteServer;
                    txtFirefoxPath.Text = settingTime.RemoteFFPath;
                    YTGlobalSettings.settingTime = settingTime;
                }
            }
            else
            {
                lstChannels.Items.Clear();
                lstComments.Items.Clear();
                lstUsedChannel.Items.Clear();
            }
        }
        public string GetContent(string address)
        {
            return new WebClient().DownloadString(address);
        }
        private void grpChannels_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if ((string)e.Button.Properties.Tag == "btnAutoFillChannel")
            {
                lstChannels.Items.Clear();

                var randomChannels = GetContent($"{YTGlobalSettings.BASE_SERVER_URI}/Settings/GetRandomChannels");

                JArray json = JArray.Parse(randomChannels);
                foreach (var item in json)
                {
                    lstChannels.Items.Add(item.ToString());
                }
            }
        }

        private void grpComments_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if ((string)e.Button.Properties.Tag == "btnAutoFillComments")
            {
                lstComments.Items.Clear();

                var randomChannels = GetContent($"{YTGlobalSettings.BASE_SERVER_URI}/Settings/GetRandomComments");

                JArray json = JArray.Parse(randomChannels);
                foreach (var item in json)
                {
                    lstComments.Items.Add(item.ToString());
                }
            }
        }

        private void lstUsedChannel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                if (lstUsedChannel.SelectedIndex >= 0)
                {
                    lstUsedChannel.Items.RemoveAt(lstUsedChannel.SelectedIndex);
                }
            }
        }
    }
}