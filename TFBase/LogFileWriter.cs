using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace TFBase
{
    class LogFileWriter
    {
        // Create and write Logfile entries
        // 
        // Log-Level:
        // [1] general info
        // [2] UserInput and normal output
        //
        // [6] non critical error (no connection to Daemon or Stack
        // [7] critical error, no App-Exception (Can't start Daemon, Can't establish a connection)
        // [8] critical exception that is blocking the further execution of the application

        // possible Logfile line:
        // [DATE & TIME] [Brick & Bricklet] [LogLevel] [LogText] [method] [Source-line]
        // 01.01.2018   [TFBase]       [8]    Can't start BrickDaemon                    [ServiceManagement]  [512]
        // 01.01.2018   [MasterBrick]  [7]    Can't establish a connection to 127.0.0.1  [CONNECTION]         [223]

        // Write own Logfile Format (can be opened with basic Text-Editor, but also in our own Application (f.e. use csv format, or something like this)
        // Also, critical issues, at least Level 8 should be logged into Windows Event Log

        Globals globals = new Globals();

        public void WriteLogFile(int LogLevel,
            string LogMessage, string AdditionalInformation = null,
            [CallerMemberName] string sourceMemberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            // Generate Date / Time Format for LogfileName
            string DateTimeFileName = DateTime.Today.ToString("yyyy-MM-dd");

            if (!Directory.Exists(globals.LOG_PATH))
            {
                try
                {
                    // Verzeichnis anlegen, falls nicht existent
                    DirectoryInfo di = Directory.CreateDirectory(globals.LOG_PATH);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Schwerwiegender Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    //write Windows EventLog-Instead?
                }
            }
            else
            {
                string LogFile = "";
                // Create FileName for Application_Log

                LogFile = globals.LOG_PATH + @"\AppLog_" + DateTimeFileName + ".log";

                try
                {
                    using (StreamWriter sw = File.AppendText(LogFile))
                    {
                        if (String.IsNullOrEmpty(AdditionalInformation))
                        {
                            LogMessage = DateTime.Now.ToString() +
                            " -- " +
                            LogLevel +
                            " -- " +
                            LogMessage +
                            Environment.NewLine +
                            "SourceFile: " +
                            Path.GetFileName(sourceFilePath) +
                            " // Method: " +
                            sourceMemberName +
                            " // Line: " +
                            sourceLineNumber +
                            Environment.NewLine;
                        }
                        else
                        {
                            LogMessage = DateTime.Now.ToString() +
                            " -- " +
                            LogLevel +
                            " -- " +
                            LogMessage +
                            Environment.NewLine +
                            "SourceFile: " +
                            Path.GetFileName(sourceFilePath) +
                            " // Method: " +
                            sourceMemberName +
                            " // Line: " +
                            sourceLineNumber +
                            Environment.NewLine +
                            AdditionalInformation +
                            Environment.NewLine;
                        }

                        sw.WriteLine(LogMessage);
                        sw.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Schwerwiegender Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    //write Windows EventLog-Instead?
                }
            }
        }
    }
}
