using NUnit.Framework;
using TestProject.Core;
using TestProject.Core.WebDriver;

namespace TestProject.TestsUI
{
    public abstract class BaseTest
    {
        protected WebDriverWrapper WebDriverWrapper { get; private set; }
        protected Logger Logger { get; private set; }

        [SetUp]
        public virtual void SetUp()
        {
            WebDriverWrapper = new WebDriverWrapper();
            WebDriverWrapper.StartBrowser();
            WebDriverWrapper.NavigateTo(Configuration.AppUrl);

            Logger ??= new Logger();
        }

        [TearDown]
        public virtual void TearDown()
        {
            WebDriverWrapper.Close();
        }
    }
}
