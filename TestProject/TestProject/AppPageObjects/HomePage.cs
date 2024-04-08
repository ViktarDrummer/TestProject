using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject.AppPageObjects
{
    public class HomePage : BasePage
    {
        private readonly By _searchIcon = By.ClassName("dark-iconheader-search__search-icon");
        private readonly By _searchPanel = By.ClassName("header-search__panel");
        private readonly By _findButton = By.XPath(".//span[@class='bth-text-layer']");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public HomePage ClickSearchIcon()
        {
            Click(_searchIcon);
            return this;
        }

        public HomePage EnterSearchTextUsingActions(string text)
        {
            var searchInput = FindChildByName(_searchPanel, "q");

            var clickAndSendKeysActions = new Actions(Driver);
            clickAndSendKeysActions.Click(searchInput)
                .Pause(TimeSpan.FromSeconds(1))
                .SendKeys(text)
                .Perform();
            return this;
        }

        public void ClickFindButton()
        {
            Click(_findButton);
        }
    }
}
