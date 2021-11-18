using DiiaUITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DiiaUITests.Steps
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
            _servicePageCOVID19 = new ServicePageCOVID19(_webDriver);
        }

        //нужно ли опять с мейн пейдж начинать? и опять куки?
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

        [When(@"I input ""(.*)"" in search field")]
        public void WhenIInputInSearchField(string p0)
        {
            _mainPage.ClickOnSearchField(); //и ввести мол в поиск Взаэмодия
        }

        [When(@"Click button Enter")]
        public void WhenClickButtonEnter()
        {
            _mainPage.ClickOnEnterButton();
        }

        [Then(@"Open search result page with text '(.*)'")]
        public void ThenOpenSearchResultPageWithText(string expectedText)
        {
            Assert.AreEqual(expectedText, _servicePageCOVID19.GetRequestText());
        }


        //2 scenario
        //нужно ли опять с мейн пейдж начинать? и опять куки?
        //[Given(@"Main page is open")]
        //public void GivenMainPageIsOpen()
        //{
        //    _mainPage.GoToMainPage();
        //}

        //[When(@"I click on cookie accept")]
        //public void WhenIClickOnCookieAccept()
        //{
        //    _mainPage.ClickOnCookieAccept();
        //}

        [When(@"I input invalid input ""(.*)"" in search field")]
        public void WhenIInputInvalidInputInSearchField(string p0)
        {
            _mainPage.ClickOnSearchField(); //и ввести мол в поиск teyuw4tu
        }     

        [When(@"Click button Enter")]
        public void WhenClickButtonEnter()
        {
            _mainPage.ClickOnEnterButton();
        }

        [Then(@"Open search result page with text '(.*)'")]
        public void ThenOpenSearchResultPageWithText(string expectedText)
        {
            Assert.AreEqual(expectedText, _servicePageCOVID19._invalidRequestText());
        }
    }
}
