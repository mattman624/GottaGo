using Plugin.SimpleLogger;
using Plugin.SimpleLogger.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Utils
{
    public class Logger : ILogger
    {
        public Logger()
        {
            
        }

        public void Configure(string logFileNameBase, int maxLogFilesCount = 5, int maxLogFileSizeKb = 100, LogLevel level = LogLevel.Warning)
        {
            CrossSimpleLogger.Current.Configure(logFileNameBase, maxLogFilesCount, maxLogFileSizeKb, level);
        }

        public void Debug(string message)
        {
            CrossSimpleLogger.Current.Debug(message);
#if DEBUG
            System.Diagnostics.Debug.WriteLine(message);
#endif
        }

        public void Error(string message, Exception ex)
        {
            CrossSimpleLogger.Current.Error(message, ex);
#if DEBUG
            System.Diagnostics.Debug.WriteLine(message, ex);
#endif
        }

        public string GetAllLogContent()
        {
            var result = CrossSimpleLogger.Current.GetAllLogContent();
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Retrieving All log content: {result}");
#endif
            return result;
        }

        public string GetCurrentLogContent()
        {
            var result = CrossSimpleLogger.Current.GetCurrentLogContent();
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Retrieving current log content: {result}");
#endif
            return result;
        }

        public string GetLogContent(string logFileName)
        {
            var result = CrossSimpleLogger.Current.GetLogContent(logFileName);

#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Retrieving current log content of {logFileName}: {result}");
#endif

            return result;
        }

        public List<string> GetLogFiles()
        {
            var result = CrossSimpleLogger.Current.GetLogFiles();

#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Retrieving current log files: {result}");
#endif

            return result;
        }

        public void Info(string message)
        {
            CrossSimpleLogger.Current.Info(message);
#if DEBUG
            System.Diagnostics.Debug.WriteLine(message);
            //System.Diagnostics.Debug.WriteLine(message);
#endif
        }

        public void PurgeLog()
        { 
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Purging log");
#endif
            CrossSimpleLogger.Current.PurgeLog();
        }

        public void SetLogLevel(LogLevel level)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Setting log level to {level}");
#endif
            CrossSimpleLogger.Current.SetLogLevel(level);
        }

        public void Warning(string message)
        {
            CrossSimpleLogger.Current.Warning(message);
#if DEBUG
            System.Diagnostics.Debug.WriteLine(message);
#endif
        }
    }
}
