using OpenQA.Selenium;
using TestProject.Core.WebDriver;

namespace TestProject.AppPageObjects
{
    public class HomePage : BasePage
    {
        private readonly By _searchIcon = By.ClassName("dark-iconheader-search__search-icon");
        private readonly By _searchPanel = By.ClassName("header-search__panel");
        private readonly By _findButton = By.XPath(".//span[@class='bth-text-layer']");

        public HomePage(WebDriverWrapper webDriverWrapper) : base(webDriverWrapper) { }

        public HomePage ClickSearchIcon()
        {
            WebDriverWrapper.Click(_searchIcon);
            return this;
        }

        public HomePage EnterSearchTextUsingActions(string text)
        {
            var searchInput = WebDriverWrapper.FindChildByName(_searchPanel, "q");
            WebDriverWrapper.ClickAndSendAction(searchInput, text);
            return this;
        }

        public void ClickFindButton()
        {
            WebDriverWrapper.Click(_findButton);
        }
    }
}
