using Diia_UITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Diia_UITests.Steps
{
    [Binding]
    public class SearchInvalidSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;

        public SearchInvalidSteps(ScenarioContext scenarioContext)
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

        [When(@"I enter ""(.*)"" in the search box")]
        public void WhenIEnterInTheSearchBox(string input)
        {
            _mainPage.EnterDataForSearch(input);
        }

        [When(@"I click to the search button")]
        public void WhenIClickToTheSearchButton()
        {
            _mainPage.SearchButtonClick();
        }

        [Then(@"I see that the page hasn't changed ""(.*)""\.")]
        public void ThenISeeThatThePageHasnTChanged_(string text)
        {
            Assert.AreEqual(text, _mainPage.GetTextFromHeaderTitle());
        }
    }
}
