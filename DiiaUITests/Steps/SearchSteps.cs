using DiiaUITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DiiaUITests.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;            
        private readonly SearchResultPage _searchResultPage;

        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");                      
            _searchResultPage = new SearchResultPage(_webDriver);
        }

       
        [When(@"I input ""(.*)"" in search field")]
        public void WhenIInputInSearchField(string validSearch)
        {
            _searchResultPage.InputInSearchField(validSearch); //и ввести мол в поиск Взаэмодия
        }

        [When(@"Push Enter button")]
        public void WhenPushEnterButton()
        {
            _searchResultPage.PushOnEnterButton();
        }

        [Then(@"Open search result page with text '(.*)'")]
        public void ThenOpenSearchResultPageWithText(string expectedText)
        {
            Assert.AreEqual(expectedText, _searchResultPage.GetRequestText());
        }


        //2 scenario        

        [When(@"I input invalid input ""(.*)"" in search field")]
        public void WhenIInputInvalidInputInSearchField(string invalidSearch)
        {
            _searchResultPage.InputInSearchField(invalidSearch); //и ввести мол в поиск teyuw4tu
        }     
               
        [Then(@"Open search result page with error message '(.*)'")]
        public void ThenOpenSearchResultPageWithErrorMessage(string expectedText)
        {
            Assert.AreEqual(expectedText, _searchResultPage.GetInvalidRequestText());
        }
    }
}
