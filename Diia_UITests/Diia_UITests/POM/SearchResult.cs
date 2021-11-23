using OpenQA.Selenium;

namespace Diia_UITests.POM
{
    class SearchResult
    {
        private readonly IWebDriver _webDriver;

        public SearchResult(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _searchRequestText = By.CssSelector("[class='search_request-text']");
        private readonly By _searchEmptyMessage = By.CssSelector("[class='search_empty-msg']");

        public bool GetToSeachResult(string message) =>
     _webDriver.FindElement(_searchRequestText).Text.Contains(message);

        public string GetToEmptyMessageResult() =>
     _webDriver.FindElement(_searchEmptyMessage).Text;
    }
}
