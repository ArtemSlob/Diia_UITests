using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Diia_UITests.POM;
using NUnit.Framework;

namespace Diia_UITests.Steps
{
    [Binding]
    public class HeaderSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;

        public HeaderSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);
        }

        [Given(@"Main page is open")]
        public void GivenMainPageIsOpen()
        {
            _mainPage.GoToMainPage();
        }

        [When(@"I click Services list on header menu")]
        public void WhenIClickServicesListOnHeaderMenu()
        {
            _mainPage.ClickOnServicesHeaderMenuDropDownLink();
        }

        [When(@"I click (.*) from Services list")]
        public void WhenIClickFromServicesList(string linkText)
        {
            _mainPage.ClickOnServicesHeaderMenuLink(linkText);
        }

        [Then(@"Page with title (.*) opens")]
        public void ThenPageWithTitleOpens(string linkText)
        {
            Assert.AreEqual(linkText, _mainPage.GetTextFromServicePageTitle());
        }
    }
}
