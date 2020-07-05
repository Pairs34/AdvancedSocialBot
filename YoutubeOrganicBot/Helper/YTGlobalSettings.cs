using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YoutubeOrganicBot.Helper
{
    public static class YTGlobalSettings
    {
        public static string BASE_SERVER_URI = "http://license.extremitysoft.com";
        public static string selectedProfile;
        public static string CHANNELS_FILE_PATH;
        public static string COMMENTS_FILE_PATH;
        public static string USEDCHANNELS_FILE_PATH;
        public static string ATASOZLERI_FILE_PATH;
        public static string SETTING_PATH = $"{Application.StartupPath}\\Profiles\\settings.json";
        public static string FIRST_RECIEVED_CHANNELID = string.Empty;
        public static string FFExecutePath;
        public static List<string> lstUsedChannels = new List<string>();
        public static Settings settingTime;
        public static string preCaption;
        public static string PROFILE_DIR = $"{Application.StartupPath}\\Profiles";
        public static string APP_DATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);   
    }
}
