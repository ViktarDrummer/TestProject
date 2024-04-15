using Microsoft.Extensions.Configuration;

namespace TestProject.Core
{
    public class Configuration
    {
        public static string BrowserType = GetAppSettingsValue("BrowserType", "Chrome");
        public static string AppUrl = GetAppSettingsValue("ApplicationUrl", string.Empty);
        public static string TestDataPath = GetAppSettingsValue("TestDataPath", string.Empty);

        public static string GetAppSettingsValue(string value, string defaultValue)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            return configuration[$"AppSettings:{value}"] ?? defaultValue;
        }
    }
}
