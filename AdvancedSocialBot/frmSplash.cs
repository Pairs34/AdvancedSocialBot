using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using IniParser;
using IniParser.Model;
using Microsoft.Win32;

namespace AdvancedSocialBot
{
    public partial class frmSplash : SplashScreen
    {
        public frmSplash()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2012-" + DateTime.Now.Year.ToString() + " Ali YILDIRIM";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        private static string CheckFor45DotVersion(int releaseKey)
        {
            if (releaseKey >= 393295)
            {
                return "4.6 or later";
            }
            if ((releaseKey >= 379893))
            {
                return "4.5.2 or later";
            }
            if ((releaseKey >= 378675))
            {
                return "4.5.1 or later";
            }
            if ((releaseKey >= 378389))
            {
                return "4.5 or later";
            }
            // This line should never execute. A non-null release key should mean
            // that 4.5 or later is installed.
            return "No 4.5 or later version detected";
        }

        private static void Get45or451FromRegistry()
        {
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    if (Convert.ToInt32(ndpKey.GetValue("Release")) < 393295)
                    {
                        MessageBox.Show(".Net Framework 4.6 veya üstü kurulu değil.");

                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show(".Net Framework 4.6 veya üstü kurulu değil.");
                    Application.Exit();
                }
            }
        }

        public static void IsVC2015to2019x64Installed()
        {
            var isInstalled = RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015to2019x64);

            if (!isInstalled)
            {
                MessageBox.Show("Microsoft Visual C++ 2015-2019 Redistributable (x64) Kurulu Değil.");
                Application.Exit();
            }
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Task.Factory.StartNew(async () =>
            {
                this.labelStatus.Text = ".Net Kontrol ediliyor.";

                Get45or451FromRegistry();

                await Task.Delay(1000);

                
                IsVC2015to2019x64Installed();

                this.labelStatus.Text = "VCRedist Kontrol ediliyor.";

                await Task.Delay(1000);

                this.Hide();
                new frmMain().ShowDialog();

            });
        }
    }
}