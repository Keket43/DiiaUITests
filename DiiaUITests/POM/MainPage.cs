using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiiaUITests.POM
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
              
        private readonly By _cookieAccept = By.CssSelector(".cookies-1_btn-1");
        
        private readonly By _firstServiceCard = By.XPath("(.//*[@id='gromadyanam']//a[@class = 'swiper_services-slide-title'])[position()=1]");

        private readonly By _navigateToServicePage = By.XPath("(.//*[@id='gromadyanam']//a[@class = 'swiper_services-slide-title'])[position()=1]");



        public MainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }
        public void ClickOnCookieAccept()
        {
            _webDriver.FindElement(_cookieAccept).Click();
        }

        public void ClickOnFirstServiceCard()
        {
            _webDriver.FindElement(_firstServiceCard).Click();
        }
              
    }
}
