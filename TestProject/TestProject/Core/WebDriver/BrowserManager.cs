using OpenQA.Selenium;
using TestProject.WebDriver;

namespace TestProject.Core.WebDriver
{
    public class BrowserManager
    {
        private readonly IWebDriver _driver;

        public BrowserManager(BrowserType browserType)
        {
            _driver = WebDriverFactory.CreateWebDriver(browserType);
        }

        public void StartBrowser(int implicitWaitTime = 10)
        {
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTime);
        }

        public void Close()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public IWebDriver GetDriver()
        {
            return _driver;
        }

        public void WindowMaximise()
        {
            _driver.Manage().Window.Maximize();
        }
    }
}
