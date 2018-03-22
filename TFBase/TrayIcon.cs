using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TFBase
{
    public partial class TrayIcon : Form
    {
        // Provides all TrayIcon Options.
        // SubMenue, like StopStart Daemon, Quick-Connect, etc.
        // Options available in Settings:
        //
        // Option: Show Connection Information with Tray Icon = True / False -> if False, use Only default
        // Option: Select TrayMenu Items:
        // Quick-Connect, Start-Stop BrickDaemon, Open LogViewer, ...
        //
        // Do we need different Icons for the Tray?
        // Options:
        // 
        // Default TF Icon: Blue+Grey                                                               : OK / DONE
        // Red TF Icon = Service Stopped => Not connected to BrickStack                             : OK / DONE
        // Green TF Icon = Service Running => Not connected to BrickStack                           : OK / DONE
        // Red + WirelessON => Service not Running + Connected to BrickStack (direct IPCon)
        // Green + WirelessON => Service Running + Connected to BrickStack (direct IPCon)
        // Default + WirelessON => Service not detected + Connected to BrickStack (direct IPCon)
        // Green + CableON => Service Running and Connected to localhost Stack


        LogFileWriter log_Writer = new LogFileWriter();

        
    }
}
