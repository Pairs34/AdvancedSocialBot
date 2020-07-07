using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSocialBot.Helper
{
    public class Settings
    {
        public bool IsCustomTextActive { get; set; }
        public int AfterVideoMinWait { get; set; }
        public int AfterVideoMaxWait { get; set; }
        public int WatchTimeMin { get; set; }
        public int WatchTimeMax { get; set; }
        public int RandomWaitMin { get; set; }
        public int RandomWaitMax { get; set; }
        public string PreCaption { get; set; }
    }
}
