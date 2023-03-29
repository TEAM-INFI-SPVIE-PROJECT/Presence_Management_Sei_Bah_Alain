using NLog;

namespace PresenceManagement.webApi.Logging
{
    public class Log:ILog
    {  
        private static NLog.ILogger logger = LogManager.GetCurrentClassLogger();

        public void Information(string msg)
            {
                    logger.Info(msg);
            }
        public void Warning(string msg)
            {
                logger.Warn(msg);
            }
        public void Error(string msg)
            {
                logger.Error(msg);
            }
        public void Debug(string msg)
            {
                logger.Debug(msg);
            }   
    }
}