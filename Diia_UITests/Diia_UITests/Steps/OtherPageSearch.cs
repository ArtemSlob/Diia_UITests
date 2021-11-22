using Diia_UITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Diia_UITests.Features
{
    [Binding]
    public class OtherPageSearch
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly Covid19 _covid19;
        private readonly SearchResult _searchResult;

        public OtherPageSearch(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _covid19 = new Covid19(_webDriver);
            _searchResult = new SearchResult(_webDriver);
        }

        [Given(@"Covid page open")]
        public void GivenCovidPageOpen()
        {
            _covid19.GoToCovid19Page();
        }
        
        [When(@"I click on the search button")]
        public void WhenIClickOnTheSearchButton()
        {
            _covid19.ButtonSearchActivationClick();
        }

       
        [When(@"I input ""(.*)"" in the search field")]
        public void WhenIInputInTheSearchField(string input)
        {
            _covid19.EnterDataForFormSearch(input);
        }

        [When(@"I click the search button on other pages")]
        public void WhenIClickTheSearchButtonOnOtherPeges()
        {
            _covid19.SearchButtonClick();
        }

        [Then(@"I see a search results page with the text ""(.*)""")]
        public void ThenISeeASearchResultPageWhithText(string text)
        {
            Assert.AreEqual(text, _searchResult.GetToSeachResult());
        }
    }
}
