using Plugin.SimpleLogger.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Client.Utilities
{
    public interface ILogger : ISimpleLogger
    {
        //bool IsTraceEnabled { get; }
        //bool IsDebugEnabled { get; }
        //bool IsInfoEnabled { get; }
        //bool IsWarnEnabled { get; }
        //bool IsErrorEnabled { get; }
        //bool IsFatalEnabled { get; }

        //void Info(string message);
        //void Info(string format, params object[] args);

        //void Error(string message);
        //void Error(string format, params object[] args);
        //void Error(Exception e, string message);
        //void Error(Exception e, string format, params object[] args);

        //void Fatal(string message);
        //void Fatal(string format, params object[] args);
        //void Fatal(Exception e, string message);
        //void Fatal(Exception e, string format, params object[] args);

        //void Debug(string message);
        //void Debug(string format, params object[] args);

        //void Trace(string message);
        //void Trace(string format, params object[] args);

        //void Warn(string message);
        //void Warn(string format, params object[] args);
    }
}

