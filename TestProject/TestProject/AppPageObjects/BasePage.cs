using OpenQA.Selenium;
using TestProject.Core;

namespace TestProject.AppPageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; }
        private TimeSpan _timeout;

        public BasePage(IWebDriver driver, int waitTimeInSeconds = 10)
        {
            Driver = driver;
            _timeout = TimeSpan.FromSeconds(waitTimeInSeconds);
        }

        protected void Click(By by)
        {
            WaitHelper.WaitForElementToBePresent(Driver, by, _timeout)?.Click();
        }

        protected void EnterText(By by, string text)
        {
            var element = WaitHelper.WaitForElementToBePresent(Driver, by, _timeout);
            element.Clear();
            element.SendKeys(text);
        }

        protected IWebElement FindChildByName(By byParent, string childName)
        {
            var elementParent = WaitHelper.WaitForElementToBePresent(Driver, byParent, _timeout);
            return elementParent.FindElement(By.Name(childName));
        }

        public string GetTitle()
        {
            return Driver.Title;
        }
    }
}
