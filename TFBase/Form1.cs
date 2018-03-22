using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;


namespace TFBase
{

    /************************************************************/
    /*        TF Base (c) 2018 by Christoph Caina               */
    /*                                                          */
    /*  Stellt die Haupt-Features für Tinkerforge-Stapel zur    */
    /*  verfügung und kann durch Plugins mit Funktionen der     */
    /*  jeweiligen Bricks und Bricklets erweitert werden.       */
    /*  Ziel ist es u.a. definierte Anwendungen, wie z.B.       */
    /*  eine Wetterstation oder andere Anwendungen bereit zu    */
    /*  stellen und zu Verwalten.                               */
    /*                                                          */
    /************************************************************/

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //==================================================================================================================================================================================

        // own ClassImplementation
        LogFileWriter log_Writer = new LogFileWriter();
        //TrayIcon tray_Icon = new TrayIcon();
        ConfigWriter conf_Writer = new ConfigWriter();
        ConfigReader conf_Reader = new ConfigReader();
        BrickDaemonManager bd_Manager = new BrickDaemonManager();
        DeviceIdentifiers dev_Ident = new DeviceIdentifiers();
        Globals globals = new Globals();

        //==================================================================================================================================================================================

        private void Form1_Load(object sender, EventArgs e)
        {
            // Show default TrayIcon.
            // We don't know if BrickDaemon Service is needed right now.
            ShowTrayIcon();
        }

        //==================================================================================================================================================================================

        private void ShowTrayIcon(string IconType = null)
        {

            BuildTrayMenu();

            // Decide, which TrayIcon we should display
            try
            {
                switch (IconType)
                {
                    case "BrickDRunning":
                        // Show BrickD Running Icon
                        break;

                    case "BrickDStopped":
                        // Show BrickD Stopped Icon
                        break;

                    // other case option needs to be inserted here

                    default:
                        // Show default TF Icon
                        TFTrayIcon.Icon = Properties.Resources.TFdefault;
                        break;
                }

                // Only, if TrayIcon Set to true in Settings?
                TFTrayIcon.Visible = true;
                TFTrayIcon.ContextMenuStrip = TFTrayIconMenu;
            }
            catch (Exception ex)
            {
                log_Writer.WriteLogFile(8, ex.Message);
            }
        }

        //==================================================================================================================================================================================

        private void BuildTrayMenu()
        {
            // AppExit is always visible and enabled.
            AppExit.Visible = true;
            AppExit.Enabled = true;

            // others depending on the settings

            // Brick Daemon Options & Submenu
            BrickDaemonOptions.Visible = true;
            BrickDaemonOptions.Enabled = false;

                ServiceStart.Visible = true;
                ServiceStart.Enabled = false;

                ServiceStop.Visible = true;
                ServiceStop.Enabled = false;

                ServicePause.Visible = true;
                ServicePause.Enabled = false;

                ServiceRestart.Visible = true;
                ServiceRestart.Enabled = false;
        }

        //==================================================================================================================================================================================

        private void AppExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //==================================================================================================================================================================================

        private void ServiceStart_Click(object sender, EventArgs e)
        {
            bd_Manager.ServiceHandler("start");
        }

        //==================================================================================================================================================================================

        private void ServiceStop_Click(object sender, EventArgs e)
        {
            bd_Manager.ServiceHandler("stop");
        }

        //==================================================================================================================================================================================

        private void ServicePause_Click(object sender, EventArgs e)
        {
            bd_Manager.ServiceHandler("pause");
        }

        //==================================================================================================================================================================================

        private void ServiceRestart_Click(object sender, EventArgs e)
        {
            bd_Manager.ServiceHandler("restart");
        }
    }
}
