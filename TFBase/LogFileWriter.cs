using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
