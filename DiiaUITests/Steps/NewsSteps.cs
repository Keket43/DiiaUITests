using DiiaUITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace DiiaUITests.Steps
{
    [Binding]
    public class NewsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly NewsPage _newsPage;

        public NewsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _newsPage = new NewsPage(_webDriver);
        }

        [When(@"I click on news button in the header")]
        public void WhenIClickOnNewsButtonInTheHeader()
        {
            _newsPage.ClickOnNewsButton();
        }
        
        [Then(@"I navigate to the News page with title ""(.*)""")]
        public void ThenINavigateToTheNewsPageWithTitle(string expectedText)
        {            
            Assert.AreEqual(expectedText, _newsPage.GetNewsPageTitle());
        }

        [When(@"I click on first news")]
        public void WhenIClickOnFirstNews()
        {
            _newsPage.ClickOnFirstCard();
        }

        [Then(@"I navigate to the first news page with title ""(.*)""")]
        public void ThenINavigateToTheFirstNewsPageWithTitle(string expectedText)
        {
            Assert.AreEqual(expectedText, _newsPage.GetFirstNewsTitle());        
        }


        [When(@"I click on more news button ""(.*)""")]
        public void WhenIClickOnMoreNewsButton(string p0)
        {
            _newsPage.ClickOnMoreNewsButton();
        }

        [Then(@"I see more news on the same page, the last one with title ""(.*)""")]
        public void ThenISeeMoreNewsOnTheSamePageTheLastOneWithTitle(string expectedLastItemText)
        {
            Assert.AreEqual(expectedLastItemText, _newsPage.GetMoreNewsButtonSeeLastItemTitleText());
        }


        [When(@"I click on fifth page button (.*)")]
        public void WhenIClickOnFifthPageButton(string button)
        {
            _newsPage.ClickOnFifthPageButton(button);
        }

        [Then(@"I navigate to the fifth news page with first news with title ""(.*)""")]
        public void ThenINavigateToTheFifthNewsPageWithFirstNewsWithTitle(string expectedTextOnFifthPage)
        {            
            Assert.AreEqual(expectedTextOnFifthPage, _newsPage.GetExpectedTextOnFifthPage());            
        }       
    }
}
