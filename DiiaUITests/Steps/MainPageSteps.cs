﻿using DiiaUITests.POM;
using NUnit.Framework;
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
        private readonly ServicePageCOVID19 _servicePageCOVID19;

        public MainPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(_webDriver);
            _servicePageCOVID19 = new ServicePageCOVID19(_webDriver);
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

        //переход на страницу первого сервиса(про ковид)
        [Then(@"I navigate to the Covid service page with title ""(.*)""")]
        public void ThenINavigateToTheCovidServicePageWithTitle(string expectedText)
        {
           Assert.AreEqual(expectedText, _servicePageCOVID19.GetTitleText());
        }


    }
}