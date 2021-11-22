using Diia_UITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Diia_UITests.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;
        private readonly SearchResult _searchResult;

        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);
            _searchResult = new SearchResult(_webDriver);
        }

        [Given(@"Main page open")]
        public void GivenMainPageOpen()
        {
            _mainPage.GoToMainPage();
        }

        [When(@"I input '(.*)' in the search field")]
        public void WhenIInputInTheSearchField(string input)
        {
            _mainPage.EnterDataForSearch(input);
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            _mainPage.SearchButtonClick();
        }

        [Then(@"I see a search result page whith text '(.*)'")]
        public void ThenISeeASearchResultPageWhithText(string text)  
        {
            Assert.AreEqual(text, _searchResult.GetToSeachResult());
        }

        [Then(@"I see a empty search result page whith text '(.*)'")]
        public void ThenISeeAEmptySearchResultPageWhithText(string text)
        {
            Assert.AreEqual(text, _searchResult.GetToEmptyMessageResult());
        }

        [Then(@"I see that the page has '(.*)' title")]
        public void ThenISeeThatThePageHasNot(string titleText)
        {
            Assert.AreEqual(titleText, _mainPage.GetTextFromHeaderTitle());
        }
    }
}
