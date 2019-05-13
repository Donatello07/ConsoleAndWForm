using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace RunningAnotherApp
{
    public class ConfigManager
    {
        public static string ReadAppPath()
        {
            string path = string.Empty;
            try
            {
                path = ConfigurationSettings.AppSettings["AppPath"];
            }
            catch (Exception x)
            {
                throw new Exception("fail Read Config ! || msg : " + x.Message);
            }
            return path;
        }

        private static void EditConfig()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.AppSettings.Settings["test"].Value = "blah";
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
