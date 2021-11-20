using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Diia_UITests.POM
{
    class MainPageSearch
    {
        private readonly IWebDriver _webDriver;

        public MainPageSearch(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _searchField = By.CssSelector("[class='input form-search_input']");
        private readonly By _searchButton = By.CssSelector("[class='btn btn_search-main']");
        private readonly By _resultSearchText = By.CssSelector("[class='search_request-text']");
        private readonly By _closedCookies = By.CssSelector("[class='cookies-1_close']");

        public MainPageSearch GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public MainPageSearch EnterDataForSearch(string input)
        {
            _webDriver
                .FindElement(_searchField)
                .SendKeys(input);
            _webDriver
                .FindElement(_closedCookies)
                .Click();
            return this;
        }

        public MainPageSearch SearchButtonClick()
        {
            _webDriver
                .FindElement(_searchButton)
                .Click();
            return this;
        }

        public string ClickToSeachResult(string text) =>
            _webDriver.FindElement(_resultSearchText).Text;
    }
}
