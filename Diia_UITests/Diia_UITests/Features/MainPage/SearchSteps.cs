using System;
using TechTalk.SpecFlow;

namespace Diia_UITests.Features.MainPage
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"main page open")]
        public void GivenMainPageOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input '(.*)' in the search field")]
        public void WhenIInputInTheSearchField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see a shearch result page whith text '(.*)'")]
        public void ThenISeeAShearchResultPageWhithText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
