using NUnit.Framework;
using TestProject.Core;
using TestProject.Core.WebDriver;
using TestProject.WebDriver;

namespace TestProject.TestsUI
{
    public abstract class BaseTest
    {
        protected BrowserManager BrowserManager { get; private set; }

        [SetUp]
        public virtual void SetUp()
        {
            var browserType = (BrowserType)Enum.Parse(typeof(BrowserType),
                Configuration.BrowserType);

            BrowserManager = new BrowserManager(browserType);
            BrowserManager.StartBrowser();
            BrowserManager.NavigateTo(Configuration.AppUrl);
        }

        [TearDown]
        public virtual void TearDown()
        {
            BrowserManager.Close();
        }
    }
}
