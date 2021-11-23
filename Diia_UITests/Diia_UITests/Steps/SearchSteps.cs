using Diia_UITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
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
            _mainPage.EnterDataInSearchField(input);
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            _mainPage.SearchButtonClick();
        }

        [Then(@"The search result page whith text '(.*)' opens")]
        public void ThenTheSearchResultPageWhithTextOpens(string message)  
        {
            Assert.IsTrue(_searchResult.GetSuccessfulSeachMessageText(message));
        }

        [Then(@"The empty search result page whith text '(.*)' opens")]
        public void ThenTheEmptySearchResultPageWhithTextOpens(string message)
        {
            Assert.AreEqual(message, _searchResult.GetFailedSeachMessageText());
        }

        [Then(@"The page with title '(.*)' does not change")]
        public void ThenThePageWithTitleDoesNotChange(string titleText)
        {
            Assert.AreEqual(titleText, _mainPage.GetTextFromPageTitle());
        }
    }
}