using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Diia_UITests.POM
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;
        private readonly WebDriverWait _wait;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _wait = new WebDriverWait(_webDriver, new TimeSpan(0, 0, 20));
        }

        private readonly By _servicesHeaderMenuDropDownLink = By.CssSelector("[data-menu-target='menu-sub-1']");
        private readonly By _servicesHeaderMenuLinks = By.CssSelector("div[id='menu-sub-1'] [class='menu-sub_list-item diia-animated']>a");
        private readonly By _servicePageTitle = By.CssSelector("h1");
        //private readonly By _headerLogo = By.CssSelector("[class='header-sm_logo']");

        public MainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public void ClickOnServicesHeaderMenuDropDownLink()
        {
            _webDriver.FindElement(_servicesHeaderMenuDropDownLink).Click();
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

        public string GetTextFromServicePageTitle()
        {
            return _webDriver.FindElement(_servicePageTitle).Text;
        }
    }
}
