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

        private readonly By _searchInputField = By.CssSelector(".input.input.form-search_input");

        private readonly By _enterButton = By.CssSelector(".btn_search-main");


        public void InputInSearchField(string validSearch)
        {
            _webDriver.FindElement(_searchInputField).SendKeys(validSearch);
        }
        public void PushOnEnterButton()
        {
            _webDriver.FindElement(_enterButton).Click();
        }

        public string SearchInfoRequestText()
        {
            return _webDriver.FindElement(_requestText).Text;
        }

        public string GetInvalidRequestText()
        {
            return _webDriver.FindElement(_invalidRequestText).Text;
        }
    }
}
