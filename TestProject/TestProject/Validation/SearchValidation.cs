using FluentAssertions;

namespace TestProject.Validation
{
    internal class SearchValidation
    {
        public static void ValidateSearchResults(
            string actualUrl,
            string expectedUrl,
            int actualSearchResultsCount)
        {
            actualUrl.Should().Be(expectedUrl, "Incorrect 'url' after searching.");
            actualSearchResultsCount.Should().BeGreaterThan(0, "Search results count should be more than 0 after searching.");
        }

        public static void ValidateFullSearchResults(
            SearchResults actualSearchResult,
            SearchResults expectedSearchResult)
        {
            actualSearchResult.SearchLabelExists.Should().Be(expectedSearchResult.SearchLabelExists, "'Search' label is not found.'");
            actualSearchResult.TextToSearchExists.Should().Be(expectedSearchResult.TextToSearchExists, "Search Text is not found after searching.");
            actualSearchResult.FindButtonExists.Should().Be(expectedSearchResult.FindButtonExists, "'Find' button is not found.");
            actualSearchResult.ResultsCount.Should().Be(expectedSearchResult.ResultsCount, "Incorrect expected results count.");
            actualSearchResult.SearchUrl.Should().Be(expectedSearchResult.SearchUrl, "Incorrect 'url' after searching.");
        }
    }
}
