using OpenQA.Selenium;

namespace Diia_UITests.POM
{
    class NewsPage
    {
        private readonly IWebDriver _webDriver;

        public NewsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _newsTitle = By.CssSelector("h1");

        public string GetTextFromPageTitle() =>
            _webDriver.FindElement(_newsTitle).Text;
    }
}