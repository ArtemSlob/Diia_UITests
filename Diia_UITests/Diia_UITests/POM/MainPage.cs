using Diia_UITests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Diia_UITests.POM
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;
        private readonly WebDriverWait _wait;
        private readonly Actions _action;
        private readonly Helper _helper;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _wait = new WebDriverWait(_webDriver, new TimeSpan(0, 0, 20));
            _action = new Actions(_webDriver);
            _helper = new Helper(_webDriver);
        }

        private readonly By _servicesHeaderMenuDropDownLink = By.CssSelector("[data-menu-target='menu-sub-1']");
        private readonly By _servicesHeaderMenuLinks = By.CssSelector("div[id='menu-sub-1'] [class='menu-sub_list-item diia-animated']>a");
        private readonly By _searchField = By.CssSelector("[class='input form-search_input']");
        private readonly By _searchButton = By.CssSelector("[class='btn btn_search-main']");
        private readonly By _headerTitle = By.CssSelector("[class='header_title']");
        private readonly By _pageTitle = By.CssSelector("h1");
        private readonly By _chatbotButton = By.CssSelector("[id='chatbot_btn']");
        private readonly By _headerMenuLinksList = By.CssSelector("ul[class='menu_list']>li");
        private readonly By _swiperNextButton = By.CssSelector("[id='gromadyanam'] [class='swiper_services-btn-next swiper-btn-next']");
        private readonly By _swiperPreviousButton = By.CssSelector("[id='gromadyanam'] [class='swiper_services-btn-prev swiper-btn-prev']");
        private readonly By _popularServicesBlocks = By.CssSelector("[id='gromadyanam'] [class^='swiper-slide swiper_services-slide']");
        private readonly By _popularServicesButton = By.CssSelector("[class='swiper_services-slide-content']>a");
        private readonly By _cookiesCloseButton = By.CssSelector("[class='cookies-1_close']");
        private readonly By _popularServicesBusinessTab = By.CssSelector("[id='biznesu-tab']");
        private readonly By _popularServicesGromadyanamTab = By.CssSelector("[id='gromadyanam-tab']");

        public MainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public void ClickOnHeaderMenuLink(string linkText)
        {
            _helper.ClickOnLinkByText(linkText, _headerMenuLinksList);
        }

        public void ClickOnServicesHeaderMenuLink(string linkText)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_servicesHeaderMenuLinks));
            _helper.ClickOnLinkByText(linkText, _servicesHeaderMenuLinks);
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

        public void EnterDataForSearch(string input)
        {
            _webDriver.FindElement(_searchField).SendKeys(input);
        }

        public void SearchButtonClick()
        {
            _webDriver.FindElement(_searchButton).Click();
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

        public void ClickOnSwiperNextButton()
        {
            _webDriver.FindElement(_swiperNextButton).Click();
        }

        public void ClickOnSwiperPreviousButton()
        {
            _webDriver.FindElement(_swiperPreviousButton).Click();
        }

        public bool CheckActivenessOfFirstPopularServiceBlock()
        {
            return _webDriver.FindElements(_popularServicesBlocks)[0].GetAttribute("class").Contains("active");
        }

        public void ClickOnCovid19InPopularService(string linkText)
        {
            _helper.ClickOnLinkByText(linkText, _popularServicesButton);
        }
        public void ClickOnPopularServicesGromadyanamTab()
        {
            _webDriver.FindElement(_popularServicesGromadyanamTab).Click();
        }

        public void ClickOnPopularServicesBusinessTab()
        {
            _webDriver.FindElement(_popularServicesBusinessTab).Click();
        }

        public bool CheckActivenessOfMenuGromadianam()
        {
            return _webDriver.FindElement(_popularServicesGromadyanamTab).GetAttribute("class").Contains("active");
        }

        public bool CheckActivenessOfMenuBusiness()
        {
            return _webDriver.FindElement(_popularServicesBusinessTab).GetAttribute("class").Contains("active");
        }

        public void ClickOnCookiesCloseButton()
        {
            _webDriver.FindElement(_cookiesCloseButton).Click();
        }
    }
}
