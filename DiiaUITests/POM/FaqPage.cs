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

    }
}
