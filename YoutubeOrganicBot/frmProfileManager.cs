using IniParser;
using IniParser.Model;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeOrganicBot.Helper;

namespace YoutubeOrganicBot
{
    public partial class frmProfileManager : Form
    {

        public frmProfileManager()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void GetUserList()
        {
            string localFFProfiles = YTGlobalSettings.APP_DATA + "\\Mozilla\\Firefox\\profiles.ini";

            if (File.Exists(localFFProfiles))
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(localFFProfiles);
                lstUserList.Items.Clear();
                foreach (var item in data.Sections.Where(x => x.SectionName.StartsWith("Profile")))
                {
                    if(!data[item.SectionName]["Name"].Contains("default"))
                        lstUserList.Items.Add(data[item.SectionName]["Name"]);
                }
            }
        }
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            CreateProfile();
        }

        private void CreateProfile()
        {
            if(YTGlobalSettings.FFExecutePath == null)
            {
                MessageBox.Show("Firefox dizini bulunamadı. Lütfen firefox'un kurulu olduğundan emin olun.");
                return;
            }

            if (!Directory.Exists(YTGlobalSettings.PROFILE_DIR))
            {
                Directory.CreateDirectory(YTGlobalSettings.PROFILE_DIR);
            }

            if (Directory.Exists($"{YTGlobalSettings.PROFILE_DIR}\\{txtProfileName.Text}"))
            {
                DialogResult dialogResult = MessageBox.Show("Bu profil daha önce oluşturulmuş.Eskisini sileyimmi ?", "Opss!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteDirectory($"{YTGlobalSettings.PROFILE_DIR}\\{txtProfileName.Text}");
                }
                else
                {
                    return;
                }
            }

            Directory.CreateDirectory($"{YTGlobalSettings.PROFILE_DIR}\\{txtProfileName.Text}");

            string param = $"-CreateProfile \"{txtProfileName.Text}\"";
            Process.Start(YTGlobalSettings.FFExecutePath, param);

            Task.Factory.StartNew(()=> {
                Thread.Sleep(1500);
                GetUserList();
                txtProfileName.ResetText();
            });            
        }

        private void frmProfileManager_Load(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void lstUserList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Process.Start(YTGlobalSettings.FFExecutePath,"-p");
            }
        }

        private void txtProfileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateProfile();
                txtProfileName.ResetText();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(YTGlobalSettings.FFExecutePath,"-p");
        }

        private void grpUserList_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if((string)e.Button.Properties.Tag == "btnRefreshProfiles")
            {
                GetUserList();
            }
        }
    }
}
