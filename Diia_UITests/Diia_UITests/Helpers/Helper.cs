using OpenQA.Selenium;

namespace Diia_UITests.Helpers
{
    class Helper
    {
        private readonly IWebDriver _webDriver;

        public Helper(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void ClickOnLinkByText(string linkText, By elementSelector)
        {
            foreach (IWebElement link in _webDriver.FindElements(elementSelector))
            {
                if (link.Text == linkText)
                {
                    link.Click();
                    break;
                }
            }
        }
    }
}