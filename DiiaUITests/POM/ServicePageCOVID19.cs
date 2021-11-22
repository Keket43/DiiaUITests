using OpenQA.Selenium;


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
