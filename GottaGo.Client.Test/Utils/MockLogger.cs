using GottaGo.Client.Utilities;
using Plugin.SimpleLogger.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GottaGo.Client.Test.Utilities
{
    public class MoqLogger : ILogger
    {
        public void Configure(string logFileNameBase, int maxLogFilesCount = 5, int maxLogFileSizeKb = 100, LogLevel level = LogLevel.Warning)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message)
        {
            log(message);
        }

        public void Error(string message, Exception ex)
        {
            log(message);
        }

        public string GetAllLogContent()
        {
            throw new NotImplementedException();
        }

        public string GetCurrentLogContent()
        {
            throw new NotImplementedException();
        }

        public string GetLogContent(string logFileName)
        {
            throw new NotImplementedException();
        }

        public List<string> GetLogFiles()
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            log(message);
        }

        public void PurgeLog()
        {
            throw new NotImplementedException();
        }

        public void SetLogLevel(LogLevel level)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            log(message);
        }

        private void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
