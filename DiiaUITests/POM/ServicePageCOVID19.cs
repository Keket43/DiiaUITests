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

        private readonly By _requestText = By.CssSelector(".search_request-text");

        private readonly By _invalidRequestText = By.CssSelector(".search_empty-msg");

        


        public string GetTitleText()
        {
            return _webDriver.FindElement(_title).Text;
            
        }
        //можно ли добавить со страницы поиска??
        public string GetRequestText()
        {
            return _webDriver.FindElement(_requestText).Text;

        }

        public string GetInvalidRequestText()
        {
            return _webDriver.FindElement(_invalidRequestText).Text;

        }
        

    }
}
