using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiiaUITests.POM
{
    class FaqPage
    {
        private readonly IWebDriver _webDriver;

        public FaqPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _title = By.CssSelector("h1");
        private readonly By _cookieAccept = By.CssSelector(".cookies-1_btn-1");
        private readonly By _faqMenuItem = By.CssSelector("[href*='https://diia.gov.ua/faq']");
        private readonly By _firstQuestionOnFaqPage = By.CssSelector("[href*='/faq/6']");
        private readonly By _firstQuestionOnSideMenu = By.CssSelector("[href*='/faq/5']");
        private readonly By _askQuestionButton = By.CssSelector("[href*='https://diia.gov.ua/faq#']");
        private readonly By _nameInput = By.CssSelector("[placeholder='Ваше ім\'я']");
        private readonly By _emailInput = By.CssSelector("[placeholder='Ваш email']");
        private readonly By _questionTitleInput = By.CssSelector("[placeholder='Тема питання']");
        private readonly By _questionInput = By.CssSelector("[placeholder='Поставте своє питання']");
        private readonly By _submitFormButton = By.Id("form-faq-item-btn");
        private readonly By _successMessage = By.CssSelector("h1");

        public string GetTitleText()
        {
            return _webDriver.FindElement(_title).Text;
        }
        public void ClickOnCookieAccept()
        {
            _webDriver.FindElement(_cookieAccept).Click();
        }

        public void ClickOnFaqMenuItem()
        {
            _webDriver.FindElement(_faqMenuItem).Click();
        }

        public void ClickOnFirstQuestionOnFaqPage()
        {
            _webDriver.FindElement(_firstQuestionOnFaqPage).Click();
        }
        public void ClickOnFirstQuestionOnSideMenu()
        {
            _webDriver.FindElement(_firstQuestionOnSideMenu).Click();
        }

        public void ClickOnAskQuestionButton()
        {
            _webDriver.FindElement(_askQuestionButton).Click();
        }

        public void InputInNameField(string name)
        {
            _webDriver.FindElement(_nameInput).SendKeys(name);
        }
        public void InputInEmailField(string email)
        {
            _webDriver.FindElement(_emailInput).SendKeys(email);
        }
        public void InputInQuestionTitleField(string title)
        {
            _webDriver.FindElement(_questionTitleInput).SendKeys(title);
        }
        public void InputInQuestionField(string question)
        {
            _webDriver.FindElement(_questionInput).SendKeys(question);
        }

        public void ClickOnSubmitFormButton()
        {
            _webDriver.FindElement(_submitFormButton).Click();
        }
        public string GetPopupTitleText()
        {
            return _webDriver.FindElement(_successMessage).Text;
        }
    }
}
