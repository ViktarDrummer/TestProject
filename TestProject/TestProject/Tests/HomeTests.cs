using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using TestProject.AppPageObjects;
using TestProject.Core;
using TestProject.Data;

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
            _homePage = new HomePage(WebDriverWrapper);
        }

        [Test]
        [TestCase("Automation", "search?q=Automation")]
        public void SearchOnIndexPageTest_Updated(
            string textToFind,
            string searchUrl)
        {
            Logger.Information("Starting the test 'SearchOnIndexPageTest_Updated'.");
            _homePage.ClickSearchIcon()
                .EnterSearchTextUsingActions(textToFind)
                .ClickFindButton();
            var currentUrl = WebDriverWrapper.GetDriver().Url;
            currentUrl.Should().Contain(searchUrl);
            Logger.Information("Ending the test 'SearchOnIndexPageTest_Updated'.");
        }

        [Test]
        [TestCaseSource(nameof(SearchModelData))]
        public void SearchOnIndexPageTest_Updated_WithJsonData(
            SearchModel searchModelItem)
        {
            Logger.Information("Starting the test 'SearchOnIndexPageTest_Updated'.");
            _homePage.ClickSearchIcon()
                .EnterSearchTextUsingActions(searchModelItem.TextToSearch)
                .ClickFindButton();
            var currentUrl = WebDriverWrapper.GetDriver().Url;
            currentUrl.Should().Contain(searchModelItem.SearchUrl);
            Logger.Information("Ending the test 'SearchOnIndexPageTest_Updated'.");
        }

        private static List<SearchModel> SearchModelData
        {
            get
            {
                var jsonData = File.ReadAllText(Configuration.TestDataPath);
                var SearchModelItems = JsonConvert.DeserializeObject<List<SearchModel>>(jsonData);
                return SearchModelItems;
            }
        }
    }
}
