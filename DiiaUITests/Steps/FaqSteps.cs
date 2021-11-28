using DiiaUITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DiiaUITests.Steps
{
    [Binding]
    class FaqSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly FaqPage _faqPage;

        public FaqSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _faqPage = new FaqPage(_webDriver);
        }

        [When(@"I click on q&a button in the header")]
        public void WhenIClickOnQAButtonInTheHeader()
        {
            _faqPage.ClickOnFaqMenuItem();
        }

        [Then(@"I navigate to the page with title ""(.*)""")]
        public void ThenINavigateToThePageWithTitle(string expectedText)
        {
            Assert.AreEqual(expectedText, _faqPage.GetTitleText());
        }

    }
}
