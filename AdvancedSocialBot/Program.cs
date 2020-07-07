using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedSocialBot.Helper;

namespace AdvancedSocialBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                //Process.GetProcesses()
                //     .Where(pr => pr.ProcessName.Contains("gecko") || pr.ProcessName.Contains("firefox"))
                //     .ForEach(p => p.Kill());
                LogManager.LogToFile("Program Başladı");
                Application.Run(new frmSplash());
            }
            catch (Exception err)
            {
                LogManager.LogToFile(err.StackTrace);
            }
        }
    }
}
