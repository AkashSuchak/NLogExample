using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace NLogExample
{
    class NLog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Fine -grained statements  conerning  program state, typically used for debugging
        /// </summary>
        /// <param name="message"></param>
        public void LogDebug (string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
