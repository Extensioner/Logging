using log4net;
using log4net.Repository;
using System;
using System.IO;

namespace Extensioner.Logging
{
    internal class Log4Neter : ILogger
    {

        private const string _logRepositoryName = "Extensioner";
        private static ILoggerRepository _logRepository;
        private static ILog _log;

        public Log4Neter()
        {
            var logCfg = new FileInfo(Directory.GetCurrentDirectory() + "\\" + "log4net.config");
            _logRepository = LogManager.CreateRepository(_logRepositoryName);
            log4net.Config.XmlConfigurator.Configure(_logRepository, logCfg);
            _log = LogManager.GetLogger(_logRepositoryName, "Log4NetLogger");
        }

        public void Debug(string context, string message)
        {
            if (_log.IsDebugEnabled)
            {
                _log.DebugFormat(context + Environment.NewLine + message);
            }

        }

        public void Info(string context, string message)
        {
            if (_log.IsInfoEnabled)
            {
                _log.InfoFormat(context + Environment.NewLine + message);
            }
        }
        public void Error(string context, string message, Exception ex)
        {
            if (_log.IsErrorEnabled)
            {
                _log.ErrorFormat(context + Environment.NewLine + message + Environment.NewLine + ex);
            }

        }
    }
}
