using System;

namespace Extensioner.Logging
{
    internal interface ILogger
    {
        void Debug(string context, string message);

        void Info(string context, string message);

        void Error(string context, string message, Exception ex);


    }
}
