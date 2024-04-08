using NLog;

namespace TestProject.Core
{
    public static class Logger
    {
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();

        public static NLog.Logger Instance => _logger;
    }
}
