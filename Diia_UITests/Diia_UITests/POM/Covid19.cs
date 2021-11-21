using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private readonly By _formSearch = By.CssSelector("[class='input_form-search-sm_input']");
        private readonly By _searchButton = By.CssSelector("[class='header_sign-search_icn_search js-header_sign-search']");
        private readonly By _searchFormButton = By.CssSelector("[class='btn_form-search-sm_btn']");

        public Covid19 GoToCovid19Page()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/services/covid19-sertifikat-pro-vakcinaciyu");
            return this;
        }

        public Covid19 EnterDataForFormSearch(string input)
        {
            _webDriver
                .FindElement(_formSearch)
                .SendKeys(input);
            return this;
        }

        public Covid19 SearchButtonClick()
        {
            _webDriver
                .FindElement(_searchFormButton)
                .Click();
            return this;
        }

        public Covid19 ButtonSearchClick()
        {
            _webDriver
                .FindElement(_searchButton)
                .Click();
            return this;
        }
    }
}
