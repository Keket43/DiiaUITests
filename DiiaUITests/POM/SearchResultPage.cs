using OpenQA.Selenium;


namespace DiiaUITests.POM
{
    class SearchResultPage
    {
        private readonly IWebDriver _webDriver;

        public SearchResultPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        private readonly By _requestText = By.CssSelector(".search_request-text");

        private readonly By _invalidRequestText = By.CssSelector(".search_empty-msg");



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
