namespace TestProject.Validation
{
    public class SearchResults
    {
        public bool SearchLabelExists { get; set; }
        public bool TextToSearchExists { get; set; }
        public bool FindButtonExists { get; set; }
        public int ResultsCount { get; set; }
        public string SearchUrl { get; set; }
    }
}
