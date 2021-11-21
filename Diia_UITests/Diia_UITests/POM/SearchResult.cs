using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diia_UITests.POM
{
    class SearchResult
    {
        private readonly IWebDriver _webDriver;

        public SearchResult(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _searchRequestText = By.CssSelector("[class='search_request-text']");

        public string GetToSeachResult(string text) =>
     _webDriver.FindElement(_searchRequestText).Text;
    }
}
