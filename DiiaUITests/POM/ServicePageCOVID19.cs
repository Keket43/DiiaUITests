using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiiaUITests.POM
{
    class ServicePageCOVID19
    {
        private readonly IWebDriver _webDriver;

        public  ServicePageCOVID19(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _title = By.CssSelector(".service-type_title");


        public string GetTitleText()
        {
            return _webDriver.FindElement(_title).Text;
            
        }
    }
}
