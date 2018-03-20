using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        //Logfile Writer
        LogFileWriter l_Writer = new LogFileWriter();
        TrayIcon trayIcon = new TrayIcon();


        private void Form1_Load(object sender, EventArgs e)
        {
            trayIcon.ShowTrayIcon();
        }
    }
}
