using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAnotherApp
{
    public class ActionServices
    {
        public static void RunApp()
        {
            string path = ConfigManager.ReadAppPath();
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = path;
                    process.Start();
                }
                catch (Exception ex)
                {
                    throw new Exception("error start File || msg : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Config is empty!");
            }
            
        }
    }
}
