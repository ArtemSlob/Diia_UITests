using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Diia_UITests.POM
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;
        private readonly WebDriverWait _wait;
        private readonly Actions _action;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _wait = new WebDriverWait(_webDriver, new TimeSpan(0, 0, 20));
            _action = new Actions(_webDriver);
        }

        private readonly By _servicesHeaderMenuDropDownLink = By.CssSelector("[data-menu-target='menu-sub-1']");
        private readonly By _servicesHeaderMenuLinks = By.CssSelector("div[id='menu-sub-1'] [class='menu-sub_list-item diia-animated']>a");
        private readonly By _searchField = By.CssSelector("[class='input form-search_input']");
        private readonly By _searchButton = By.CssSelector("[class='btn btn_search-main']");
        private readonly By _headerTitle = By.CssSelector("[class='header_title']");
        private readonly By _pageTitle = By.CssSelector("h1");
        private readonly By _chatbotButton = By.CssSelector("[id='chatbot_btn']");
        private readonly By _headerMenuLinksList = By.CssSelector("ul[class='menu_list']>li");
        private readonly By _popularServicesButton = By.CssSelector("[class='swiper_services-slide-content']>a");
        private readonly By _buttonGromadyanamActiv = By.CssSelector("[class='nav-link active']");
        private readonly By _buttunBusinessActiv = By.CssSelector("[class='nav-link active']");

        public MainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public void ClickOnHeaderMenuLink(string linkText)
        {
            foreach (IWebElement link in _webDriver.FindElements(_headerMenuLinksList))
            {
                if (link.Text == linkText)
                {
                    link.Click();
                    break;
                }
            }
        }

        public void ClickOnServicesHeaderMenuLink(string linkText)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_servicesHeaderMenuLinks));
            foreach (IWebElement link in _webDriver.FindElements(_servicesHeaderMenuLinks))
            {
                if (link.Text == linkText)
                {
                    link.Click();
                    break;
                }
            }
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

        public string GetTextFromHeaderTitle()
        {
            return _webDriver.FindElement(_headerTitle).Text;
        }

        public string GetTextFromPageTitle()
        {
            return _webDriver.FindElement(_pageTitle).Text;
        }

        public void ClickOnChatbotButtonSection()
        {
            _action.MoveToElement(_webDriver.FindElement(_chatbotButton)).Click().Perform();
        }

        public string CheckActivenessOfMenu()
        {
            return _webDriver.FindElement(_servicesHeaderMenuDropDownLink).GetAttribute("class").Contains("active") ? "active" : "inactive";
        }

        public void ClickOnCovid19InPopularService()
        {
            _webDriver.FindElements(_popularServicesButton)[0].Click();
        }

        public string CheckActivenessOfMenuGromadianam()
        {
            return _webDriver.FindElement(_buttonGromadyanamActiv).GetAttribute("class").Contains("active") ? "active" : "inactive";
        }

        public string CheckActivenessOfMenuBusiness()
        {
            return _webDriver.FindElement(_buttunBusinessActiv).GetAttribute("class").Contains("active") ? "active" : "inactive";
        }
    }
}
