﻿namespace TFBase
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TFTrayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BrickDaemonOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceStop = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicePause = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LogViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.AppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TFTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TFTrayIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TFTrayIconMenu
            // 
            this.TFTrayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrickDaemonOptions,
            this.AppExit});
            this.TFTrayIconMenu.Name = "TFTrayIconMenu";
            this.TFTrayIconMenu.Size = new System.Drawing.Size(149, 48);
            // 
            // BrickDaemonOptions
            // 
            this.BrickDaemonOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServiceStart,
            this.ServiceStop,
            this.ServicePause,
            this.ServiceRestart,
            this.toolStripSeparator1,
            this.LogViewer});
            this.BrickDaemonOptions.Image = global::TFBase.Properties.Resources.Target;
            this.BrickDaemonOptions.Name = "BrickDaemonOptions";
            this.BrickDaemonOptions.Size = new System.Drawing.Size(148, 22);
            this.BrickDaemonOptions.Text = "Brick Daemon";
            // 
            // ServiceStart
            // 
            this.ServiceStart.Image = global::TFBase.Properties.Resources.Play;
            this.ServiceStart.Name = "ServiceStart";
            this.ServiceStart.Size = new System.Drawing.Size(180, 22);
            this.ServiceStart.Text = "Starten";
            this.ServiceStart.Click += new System.EventHandler(this.ServiceStart_Click);
            // 
            // ServiceStop
            // 
            this.ServiceStop.Image = global::TFBase.Properties.Resources.Stop;
            this.ServiceStop.Name = "ServiceStop";
            this.ServiceStop.Size = new System.Drawing.Size(180, 22);
            this.ServiceStop.Text = "Beenden";
            this.ServiceStop.Click += new System.EventHandler(this.ServiceStop_Click);
            // 
            // ServicePause
            // 
            this.ServicePause.Image = global::TFBase.Properties.Resources.Pause;
            this.ServicePause.Name = "ServicePause";
            this.ServicePause.Size = new System.Drawing.Size(180, 22);
            this.ServicePause.Text = "Pausieren";
            this.ServicePause.Click += new System.EventHandler(this.ServicePause_Click);
            // 
            // ServiceRestart
            // 
            this.ServiceRestart.Image = global::TFBase.Properties.Resources.Next_track;
            this.ServiceRestart.Name = "ServiceRestart";
            this.ServiceRestart.Size = new System.Drawing.Size(180, 22);
            this.ServiceRestart.Text = "Neustarten";
            this.ServiceRestart.Click += new System.EventHandler(this.ServiceRestart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // LogViewer
            // 
            this.LogViewer.Image = global::TFBase.Properties.Resources.Notes;
            this.LogViewer.Name = "LogViewer";
            this.LogViewer.Size = new System.Drawing.Size(180, 22);
            this.LogViewer.Text = "LogViewer";
            this.LogViewer.Click += new System.EventHandler(this.LogViewer_Click);
            // 
            // AppExit
            // 
            this.AppExit.CheckOnClick = true;
            this.AppExit.Image = global::TFBase.Properties.Resources.AppExit;
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(148, 22);
            this.AppExit.Text = "Beenden";
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // TFTrayIcon
            // 
            this.TFTrayIcon.Visible = true;
            this.TFTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TFTrayIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.TFTrayIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip TFTrayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem AppExit;
        private System.Windows.Forms.NotifyIcon TFTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem BrickDaemonOptions;
        private System.Windows.Forms.ToolStripMenuItem ServiceStart;
        private System.Windows.Forms.ToolStripMenuItem ServiceStop;
        private System.Windows.Forms.ToolStripMenuItem ServicePause;
        private System.Windows.Forms.ToolStripMenuItem ServiceRestart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LogViewer;
    }
}

