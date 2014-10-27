using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseLibrary.Logging.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializes the Logging Application Block
            LogWriterFactory logWriterFactory = new LogWriterFactory();
            LogWriter logWriter = logWriterFactory.Create();

            LogEntry logEntry = new LogEntry();
            logEntry.Message = "Message logged";
            logEntry.Categories.Add("General");

            logWriter.Write(logEntry);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
