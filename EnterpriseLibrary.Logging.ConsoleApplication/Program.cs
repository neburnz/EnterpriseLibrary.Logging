// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
namespace EnterpriseLibrary.Logging.ConsoleApplication
{
    using System;
    using Microsoft.Practices.EnterpriseLibrary.Logging;

    /// <summary>
    /// Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        /// <param name="args">Additional arguments</param>
        static void Main(string[] args)
        {
            // Initializes the Logging Application Block
            LogWriterFactory logWriterFactory = new LogWriterFactory();
            LogWriter logWriter = logWriterFactory.Create();

            LogEntry logEntry = null;
            
            logEntry = new LogEntry();
            logEntry.Message = "General message logged";
            logEntry.Categories.Add("General");
            logWriter.Write(logEntry);

            logEntry = new LogEntry();
            logEntry.Message = "Warning message logged";
            logEntry.Severity = System.Diagnostics.TraceEventType.Warning;
            logWriter.Write(logEntry);

            logEntry = new LogEntry();
            logEntry.Message = "Error message logged";
            logEntry.Severity = System.Diagnostics.TraceEventType.Error;
            logWriter.Write(logEntry);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
