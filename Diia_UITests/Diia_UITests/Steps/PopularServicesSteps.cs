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
        public void GivenTheCookiesPop_UpClose()
        {
            _mainPage.ClickOnCookiesCloseButton();
        }

        [When(@"I click on the swiper next button")]
        public void WhenIClickOnTheSwiperNextButton()
        {
            _mainPage.ClickOnSwiperNextButton();
        }

        [Then(@"The popular services moved by one position right")]
        public void ThenThePopularServicesMovedByOnePositionRight()
        {
            Assert.IsTrue(!_mainPage.CheckActivenessOfFirstPopularServiceBlock());
        }

        [When(@"I click on the swiper previous button")]
        public void WhenIClickOnTheSwiperPreviousButton()
        {
            _mainPage.ClickOnSwiperPreviousButton();
        }

        [Then(@"The popular services moved by one position left")]
        public void ThenThePopularServicesMovedByOnePositionLeft()
        {
            Assert.IsTrue(_mainPage.CheckActivenessOfFirstPopularServiceBlock());
        }

        [When(@"I click the service '(.*)' in the item field")]
        public void WhenIClickTheServiceInTheItemField(string serviceName)
        {
            _mainPage.ClickOnCovid19InPopularService(serviceName);
        }


        [Then(@"A page will open with the title '(.*)'")]
        public void ThenAPageWillOpenWithTheTitle(string text)
        {
            Assert.AreEqual(text, _covid19.GetTextFromPageCovid19Title());
        }

        [When(@"I click the Business button")]
        public void WhenIClickTheBusinessButton()
        {
            _mainPage.ClickOnPopularServicesBusinessTab();
        }

        [Then(@"A page with the heading Business will open")]
        public void ThenAPageWithTheHeadingWillOpen()
        {
            Assert.IsTrue(_mainPage.CheckActivenessOfMenuBusiness());
        }

        [When(@"I click the Gromadyanam button")]
        public void WhenIClickTheGromadyanamButton()
        {
            _mainPage.ClickOnPopularServicesGromadyanamTab();
        }
        [Then(@"A page with the heading Gromadyanam will open")]
        public void ThenAPageWithHeadingWillOpen()
        {
            Assert.IsTrue(_mainPage.CheckActivenessOfMenuGromadianam());
        }
    }
}
