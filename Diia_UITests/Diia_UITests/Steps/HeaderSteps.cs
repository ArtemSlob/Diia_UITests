using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Diia_UITests.POM;
using NUnit.Framework;

namespace Diia_UITests.Steps
{
    [Binding]
    public class HeaderSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;
        private readonly NewsPage _newsPage;
        private readonly FaqPage _faqPage;

        public HeaderSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);
            _newsPage = new NewsPage(_webDriver);
            _faqPage = new FaqPage(_webDriver);
        }

        [Given(@"Main page is open")]
        public void GivenMainPageIsOpen()
        {
            _mainPage.GoToMainPage();
        }

        [When(@"I click the link (.*) from header menu Services list")]
        public void WhenIClickTheLinkFromHeaderMenuServicesList(string linkText)
        {
            _mainPage.ClickOnServicesHeaderMenuLink(linkText);
        }

        [When(@"I click on an area outside the header menu")]
        public void WhenIClickOnAnAreaOutsideTheHeaderMenu()
        {
            _mainPage.ClickOnChatbotButtonSection();
        }

        [When(@"I click the link '(.*)' in the header menu")]
        public void WhenIClickTheLinkInTheHeaderMenu(string linkText)
        {
            _mainPage.ClickOnHeaderMenuLink(linkText);
        }

        [Then(@"The header pop-up menu expands")]
        public void ThenTheHeaderPopUpMenuExpands()
        {
            Assert.IsTrue(_mainPage.CheckActivenessOfHeaderMenu());
        }

        [Then(@"The header pop-up menu collapses")]
        public void ThenTheHeaderPopUpMenuCollapses()
        {
            Assert.IsTrue(!_mainPage.CheckActivenessOfHeaderMenu());
        }

        [Then(@"Page with title (.*) opens")]
        public void ThenPageWithTitleOpens(string titleText)
        {
            Assert.AreEqual(titleText, _mainPage.GetTextFromPageTitle());
        }

        [Then(@"The News page with title '(.*)' opens")]
        public void ThenTheNewsPageWithTitleOpens(string titleText)
        {
            Assert.AreEqual(titleText, _newsPage.GetTextFromPageTitle());
        }

        [Then(@"The Faq page with title '(.*)' opens")]
        public void ThenTheFaqPageWithTitleOpens(string titleText)
        {
            Assert.AreEqual(titleText, _faqPage.GetTextFromPageTitle());
        }
    }
}
