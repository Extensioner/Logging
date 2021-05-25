using System;

namespace Extensioner.Logging
{
    public static class Log
    {
        private readonly static ILogger _log;

        static Log()
        {
            _log = new Log4Neter();
        }

        public static void Debug(string message)
        {
            var traces = Environment.StackTrace.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            _log.Debug(traces[2].ToString(), message);
        }

        public static void Info(string message)
        {
            var traces = Environment.StackTrace.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            _log.Info(traces[2].ToString(), message);

        }

        public static void Error(string message, Exception ex)
        {
            var traces = Environment.StackTrace.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            _log.Error(traces[2].ToString(), message, ex);
        }

    }
}
