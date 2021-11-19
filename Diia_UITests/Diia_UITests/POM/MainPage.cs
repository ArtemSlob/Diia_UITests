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
    }
}
