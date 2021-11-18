using OpenQA.Selenium;

namespace Diia_UITests.POM
{
    class ServicePage
    {
        private readonly IWebDriver _webDriver;

        public ServicePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _servicePageTitle = By.CssSelector("h1");

        public string GetTextFromServicePageTitle()
        {
            return _webDriver.FindElement(_servicePageTitle).Text;
        }
    }
}
