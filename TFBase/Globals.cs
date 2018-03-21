using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace TFBase
{
    class Globals
    {
        // Global VARS

        public string LOG_PATH = Application.ExecutablePath + @"\logs\";
        public string APP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + Assembly.GetCallingAssembly().EntryPoint.DeclaringType.Namespace;
        public string PLUGIN_PATH = Application.ExecutablePath + @"\plugins\";

        // Global CONSTANTS


    }
}
