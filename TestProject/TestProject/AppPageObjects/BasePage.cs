using TestProject.Core.WebDriver;

namespace TestProject.AppPageObjects
{
    public abstract class BasePage
    {
        protected WebDriverWrapper WebDriverWrapper { get; }

        public BasePage(WebDriverWrapper webDriverWrapper)
        {
            WebDriverWrapper = webDriverWrapper;
        }
    }
}
