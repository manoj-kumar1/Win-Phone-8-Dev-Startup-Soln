using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleNews.Common
{
    class Bootsrapper
    {
        public static void Initialize()
        {
            //more

            LoadAppDefaults();
        }

        private static void LoadAppDefaults()
        {
            var settings = new AppSettings();

            if (!settings.ContainsKey(GlobalConstants.Settings.IsShowSummary))
            {
                settings.AddOrUpdateValue(GlobalConstants.Settings.IsShowSummary, true);
            }

            settings.Save();
        }
    }
}
