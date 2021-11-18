using DiiaUITests.POM;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DiiaUITests.Steps
{
    [Binding]
    public class MainPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;

        public MainPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);

        }


        [Given(@"Main page is open")]
        public void GivenMainPageIsOpen()
        {
            _mainPage.GoToMainPage();
        }

        [When(@"I click on cookie accept")]
        public void WhenIClickOnCookieAccept()
        {
            _mainPage.ClickOnCookieAccept();
        }


        [When(@"I click on first service")]
        public void WhenIClickOnFirstService()
        {
            _mainPage.ClickOnFirstServiceCard();
        }

        [Then(@"I navigate to the service page")]
        public void ThenINavigateToTheServicePage()
        {
            _mainPage.ClickOnFirstServiceCard();
        }


    }
}
