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

        // define Application LogPath
        public string LOG_PATH = Application.ExecutablePath + @"\logs\";

        // define Users AppPath (AppData\Roaming\NameSpace f.e. for user-Specific Config)
        public string APP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + Assembly.GetCallingAssembly().EntryPoint.DeclaringType.Namespace;
        
        // define Path for Plugin extensions
        public string PLUGIN_PATH = Application.ExecutablePath + @"\plugins\";

        // define ServiceName for Brick Daemon
        public string BRICK_D = "Brick Daemon"; 






        // Global CONSTANTS


    }
}
