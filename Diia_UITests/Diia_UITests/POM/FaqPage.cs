using OpenQA.Selenium;

namespace Diia_UITests.POM
{
    class FaqPage
    {
        private readonly IWebDriver _webDriver;

        public FaqPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _faqTitle = By.CssSelector("h1");

        public string GetTextFromPageTitle() =>
            _webDriver.FindElement(_faqTitle).Text;
    }
}