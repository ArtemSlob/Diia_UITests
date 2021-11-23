using Diia_UITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Diia_UITests.Features
{
    [Binding]
    public class OtherPagesSearch
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly Covid19 _covid19;

        public OtherPagesSearch(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _covid19 = new Covid19(_webDriver);
        }

        [Given(@"Covid page open")]
        public void GivenCovidPageOpen()
        {
            _covid19.GoToCovid19Page();
        }
        
        [When(@"I click the search button activation in the header")]
        public void WhenIClickTheSearchButtonActivationInTheHeader()
        {
            _covid19.ButtonSearchActivationClick();
        }
       
        [When(@"I input '(.*)' in the search field in the header")]
        public void WhenIInputInTheSearchFieldInTheHeader(string input)
        {
            _covid19.EnterDataForFormSearch(input);
        }

        [When(@"I click the search button in the header")]
        public void WhenIClickTheSearchButtonInTheHeader()
        {
            _covid19.SearchButtonClick();
        }

        [Then(@"The Covid page with title '(.*)' does not change")]
        public void ThenTheCovidPageWithTitleDoesNotChange(string titleText)
        {
            Assert.AreEqual(titleText, _covid19.GetTextFromPageCovid19Title());
        }
    }
}