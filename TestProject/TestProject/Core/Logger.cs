using Serilog;

namespace TestProject.Core
{
    public class Logger
    {
        private readonly ILogger _logger;

        public Logger()
        {
            _logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }

        public void Information(string message)
        {
            _logger.Information("[INFO]: " + message);
        }

        public void Error(string message)
        {
            _logger.Error("[ERROR]: " + message);
        }

        // Other methods for different logger levels like Debug, Warning, etc.
    }
}
