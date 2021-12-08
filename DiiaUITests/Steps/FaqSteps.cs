using DiiaUITests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        //Scenario 1: Check navigation to FAQ page from the main page
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

        //Scenario 2: Check navigation to the page with answer on question
        [Given(@"FAQ page is opened")]
        public void GivenFAQPageIsOpened()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/faq/");
        }

        [When(@"I click on first question")]
        public void WhenIClickOnFirstQuestion()
        {
            _faqPage.ClickOnFirstQuestionOnFaqPage();
        }

        //Scenario 3: Check navigation to connected questions from the answer page
        [Given(@"Question page is opened")]
        public void GivenQuestionPageIsOpened()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/faq/6/");
        }

        [When(@"I click on first question on a side menu")]
        public void WhenIClickOnFirstQuestionOnASideMenu()
        {
            _faqPage.ClickOnFirstQuestionOnSideMenu();
        }

        //Scenario 4: Check the ability to send question with form on the FAQ page
        [When(@"I click on the ask question button")]
        public void WhenIClickOnTheAskQuestionButton()
        {
            Thread.Sleep(1000);
            _faqPage.ClickOnAskQuestionButton();
        }

        [When(@"I fill the name input with text ""(.*)"" in the pop up form")]
        public void WhenIFillTheNameInputWithTextInThePopUpForm(string name)
        {
            _faqPage.InputInNameField(name);
        }

        [When(@"I fill the email input with text ""(.*)"" in the pop up form")]
        public void WhenIFillTheEmailInputWithTextInThePopUpForm(string email)
        {
            _faqPage.InputInEmailField(email);
        }

        [When(@"I fill the input question title with text ""(.*)"" in the pop up form")]
        public void WhenIFillTheInputWithTextInThePopUpForm(string title)
        {
            _faqPage.InputInQuestionTitleField(title);
        }

        [When(@"I fill the question input with text ""(.*)"" in the pop up form")]
        public void WhenIFillTheQuestionInputWithTextInThePopUpForm(string question)
        {
            _faqPage.InputInQuestionField(question);
        }

        [When(@"I click form submit button")]
        public void WhenIClickFormSubmitButton()
        {
            _faqPage.ClickOnSubmitFormButton();
        }

        [Then(@"Pop up with title ""(.*)"" appears")]
        public void ThenPopUpWithTitleAppears(string expectedText)
        {
            Assert.AreEqual(expectedText, _faqPage.GetPopupTitleText());
        }



    }
}
