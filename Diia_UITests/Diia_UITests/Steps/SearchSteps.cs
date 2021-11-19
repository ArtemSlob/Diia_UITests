using Diia_UITests.POM;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Diia_UITests.Features.MainPage
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPageSearch _mainPageSearch;
        
        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPageSearch = new MainPageSearch(_webDriver);
        }

        [Given(@"Main page open")]
        public void GivenMainPageOpen()
        {
            _mainPageSearch.GoToMainPage();
        }
        
        [When(@"I input '(.*)' in the search field")]
        public void WhenIInputInTheSearchField(string input)
        {
            _mainPageSearch.EnterDataForSearch(input);
        }
        
        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            _mainPageSearch.SearchButtonClick();
        }
        
        [Then(@"I see a shearch result page whith text '(.*)'")]
        public void ThenISeeAShearchResultPageWhithText(string text)
        {
            _mainPageSearch.ClickToSeachResult(text);
        }
    }
}
