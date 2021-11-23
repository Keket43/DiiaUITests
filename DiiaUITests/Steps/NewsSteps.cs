using DiiaUITests.POM;
using OpenQA.Selenium;
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
        public void ThenINavigateToTheNewsPageWithTitle(string p0)
        {
            _newsPage.GetNewsPageTitle();
        }

        [When(@"I click on first news")]
        public void WhenIClickOnFirstNews()
        {
            _newsPage.ClickOnFirstCard();
        }

        [Then(@"I navigate to the first news page with title ""(.*)""")]
        public void ThenINavigateToTheFirstNewsPageWithTitle(string p0)
        {
            _newsPage.GetFirstNewsTitle();
        }        

        [When(@"I click on third news")]
        public void WhenIClickOnThirdNews()
        {
           _newsPage.ClickOnThirdCard();
        }

        [Then(@"I navigate to the third news page with title ""(.*)""")]
        public void ThenINavigateToTheThirdNewsPageWithTitle(string p0)
        {
            _newsPage.GetThirdNewsTitle();
        }
    }
}
