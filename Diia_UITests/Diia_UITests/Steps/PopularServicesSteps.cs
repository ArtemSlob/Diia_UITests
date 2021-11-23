using Diia_UITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Diia_UITests.Steps
{
    [Binding]
    public class PopularServicesSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;
        private readonly Covid19 _covid19;

        public PopularServicesSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);
            _covid19 = new Covid19(_webDriver);
        }

        [Given(@"The cookies pop-up close")]
        public void GivenTheCookiesPopUpClose()
        {
            _mainPage.ClickOnCookiesCloseButton();
        }

        [When(@"I click on the swiper button next")]
        public void WhenIClickOnTheSwiperButtonNext()
        {
            _mainPage.ClickOnSwiperNextButton();
        }

        [Then(@"The popular services moved by one position right")]
        public void ThenThePopularServicesMovedByOnePositionRight()
        {
            Assert.IsTrue(!_mainPage.CheckActivenessOfFirstPopularServiceBlock());
        }

        [When(@"I click on the swiper button previous")]
        public void WhenIClickOnTheSwiperButtonPrevious()
        {
            _mainPage.ClickOnSwiperPreviousButton();
        }

        [Then(@"The popular services moved by one position left")]
        public void ThenThePopularServicesMovedByOnePositionLeft()
        {
            Assert.IsTrue(_mainPage.CheckActivenessOfFirstPopularServiceBlock());
        }

        [When(@"I click the service '(.*)' in the popular service module")]
        public void WhenIClickTheServiceInThePopularServiceModule(string serviceName)
        {
            _mainPage.ClickOnCovid19InPopularService(serviceName);
        }

        [Then(@"The page with the title '(.*)' will open")]
        public void ThenThePageWithTheTitleWillOpen(string titleText)
        {
            Assert.AreEqual(titleText, _covid19.GetTextFromPageCovid19Title());
        }

        [When(@"I click the Business tab in popular services module")]
        public void WhenIClickTheBusinessTabInPopularServicesModule()
        {
            _mainPage.ClickOnPopularServicesBusinessTab();
        }

        [Then(@"The popular services module will switch to Business section")]
        public void ThenThePopularServicesModuleWillSwitchToBusinessSection()
        {
            Assert.IsTrue(_mainPage.CheckActivenessOfMenuBusiness());
        }

        [When(@"I click the Gromadyanam tab in popular services module")]
        public void WhenIClickTheGromadyanamTabInPopularServicesModule()
        {
            _mainPage.ClickOnPopularServicesGromadyanamTab();
        }

        [Then(@"The popular services module will switch to Gromadyanam section")]
        public void ThenThePopularServicesModuleWillSwitchToGromadyanamSection()
        {
            Assert.IsTrue(_mainPage.CheckActivenessOfMenuGromadianam());
        }
    }
}
