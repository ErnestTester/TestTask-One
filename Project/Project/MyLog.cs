using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MyLog
    {
        private readonly string logFilePath;
        

        public MyLog(string filePath)
        {
            logFilePath=filePath;
        }
        public void Log( string level, string message)
        {
            try
            {
                string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}]-{message}";
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging message: {ex.Message}");
            }
        }

            public void Info(string message)
            {
                Log("INFO", message);
            }

            public void Warning(string message)
            {
                Log("WARNING", message);
            }

            public void Error(string message)
            {
                Log("ERROR", message);
            }
        }

    

}
