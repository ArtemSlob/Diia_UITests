using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Diia_UITests.POM;
using NUnit.Framework;

namespace Diia_UITests.Steps
{
    [Binding]
    public class ServicesSubMenuSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;
        private readonly ServicePage _servicePage;


        public ServicesSubMenuSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);
            _servicePage = new ServicePage(_webDriver);
        }

        [Given(@"Main page is open")]
        public void GivenMainPageIsOpen()
        {
            
            _mainPage.GoToMainPage();
        }

        [When(@"I click Послуги item on header menu")]
        public void WhenIClickПослугиItemOnHeaderMenu()
        {
            _mainPage.ClickOnServicesHeaderMenuDropDownLink();
        }

        [When(@"I click first item Довідки та витяги from the list")]
        public void WhenIClickFirstItemДовідкиТаВитягиFromTheList()
        {
            _scenarioContext["TextFromServicesHeaderMenuFirstLink"] = _mainPage.GetTextFromServicesHeaderMenuFirstLink();
            _mainPage.ClickOnServicesHeaderMenuFirstLink();
        }

        [Then(@"Page with title Довідки та витяги openes")]
        public void ThenPageWithTitleДовідкиТаВитягиOpenes()
        {
            
            Assert.AreEqual(_scenarioContext["TextFromServicesHeaderMenuFirstLink"], _servicePage.GetTextFromServicePageTitle());
        }
    }
}
