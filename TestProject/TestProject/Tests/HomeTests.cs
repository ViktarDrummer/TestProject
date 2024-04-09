using FluentAssertions;
using NUnit.Framework;
using TestProject.Core;
using TestProject.AppPageObjects;

namespace TestProject.TestsUI
{
    [TestFixture]
    public class HomeTests : BaseTest
    {
        private HomePage _homePage;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            _homePage = new HomePage(BrowserManager.GetDriver());
        }

        [Test]
        [TestCase("Automation", "search?q=Automation")]
        public void SearchOnIndexPageTest_Updated(
            string textToFind,
            string searchUrl)
        {
            Logger.Instance.Info("Starting the test 'SearchOnIndexPageTest_Updated'.");
            _homePage.ClickSearchIcon()
                .EnterSearchTextUsingActions(textToFind)
                .ClickFindButton();
            var currentUrl = BrowserManager.GetDriver().Url;
            currentUrl.Should().Contain(searchUrl);
            Logger.Instance.Info("Ending the test 'SearchOnIndexPageTest_Updated'.");
        }
    }
}
