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
        private readonly MainPage _mainPage;
        
        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);
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
        
        [Then(@"I see a shearch result page whith text '(.*)'")]
        public void ThenISeeAShearchResultPageWhithText(string text)
        {
            _mainPage.ClickToSeachResult(text);
        }
    }
}
