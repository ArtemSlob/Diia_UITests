using OpenQA.Selenium;
using System;

namespace Diia_UITests.POM
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _servicesHeaderMenuDropDownLink = By.CssSelector("[data-menu-target='menu-sub-1']");
        private readonly By _servicesHeaderMenuLinks = By.CssSelector("div[id='menu-sub-1'] [class='menu-sub_list-item diia-animated']>a");
        private readonly By _searchField = By.CssSelector("[class='input form-search_input']");
        private readonly By _searchButton = By.CssSelector("[class='btn btn_search-main']");

        public MainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public void ClickOnServicesHeaderMenuFirstLink()
        {
            _webDriver.FindElements(_servicesHeaderMenuDropDownLink)[0].Click();
        }

        public void ClickOnServicesHeaderMenuDropDownLink()
        {
            _webDriver.FindElement(_servicesHeaderMenuDropDownLink).Click();
        }

        public string GetTextFromServicesHeaderMenuFirstLink()
        {
            return _webDriver.FindElements(_servicesHeaderMenuDropDownLink)[0].Text;
        }

        public MainPage EnterDataForSearch(string input)
        {
            _webDriver
                .FindElement(_searchField)
                .SendKeys(input);
            return this;
        }

        public MainPage SearchButtonClick()
        {
            _webDriver
                .FindElement(_searchButton)
                .Click();
            return this;
        }
    }
}
