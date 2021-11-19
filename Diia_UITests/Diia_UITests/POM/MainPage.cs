﻿using OpenQA.Selenium;

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
        private readonly By _resultSearchText = By.CssSelector("[class='search_request-text']");
        private readonly By _searchField = By.CssSelector("[class='input form - search_input']");
        private readonly By _searchButton = By.CssSelector("[input ='type=submit']");

        public MainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public void ClickOnServicesHeaderMenuDropDownLink()
        {
            _webDriver.FindElement(_servicesHeaderMenuDropDownLink).Click();
        }

        public void ClickToSearchButton()
        {
            _webDriver.FindElement(_servicesHeaderMenuDropDownLink).Click();
        }

        public void ClickOnServicesHeaderMenuFirstLink()
        {
            _webDriver.FindElements(_servicesHeaderMenuDropDownLink)[0].Click();
        }

        public string GetTextFromServicesHeaderMenuFirstLink()
        {
            return _webDriver.FindElements(_servicesHeaderMenuDropDownLink)[0].Text;
        }
    }
}
