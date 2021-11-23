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

        private readonly By _successfulSearchMessage = By.CssSelector("[class='search_request-text']");
        private readonly By _failedSearchMessage = By.CssSelector("[class='search_empty-msg']");

        public bool GetSuccessfulSeachMessageText(string message) =>
            _webDriver.FindElement(_successfulSearchMessage).Text.Contains(message);

        public string GetFailedSeachMessageText() =>
            _webDriver.FindElement(_failedSearchMessage).Text;
    }
}