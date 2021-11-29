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


    }
}
