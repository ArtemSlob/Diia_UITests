using OpenQA.Selenium;

namespace Diia_UITests.POM
{
    class Covid19
    {
        private readonly IWebDriver _webDriver;

        public Covid19(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _searchField = By.CssSelector("[class='input form-search-sm_input']"); 
        private readonly By _searchButtonActivation = By.CssSelector("[class='header_sign-search icn_search js-header_sign-search']");
        private readonly By _searchFormButton = By.CssSelector("[class='btn form-search-sm_btn']");

        public Covid19 GoToCovid19Page()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/services/covid19-sertifikat-pro-vakcinaciyu");
            return this;
        }

        public Covid19 EnterDataForFormSearch(string input)
        {
            _webDriver
                .FindElement(_searchField)
                .SendKeys(input);
            return this;
        }

        public Covid19 ButtonSearchActivationClick()
        {
            _webDriver
                .FindElement(_searchButtonActivation)
                .Click();
            return this;
        }

        public Covid19 SearchButtonClick()
        {
            _webDriver
                .FindElement(_searchFormButton)
                .Click();
            return this;
        }
    }
}
