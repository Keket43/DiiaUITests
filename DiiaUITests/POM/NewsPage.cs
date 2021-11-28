using OpenQA.Selenium;


namespace DiiaUITests.POM
{
    class NewsPage
    {
        private readonly IWebDriver _webDriver;

        public NewsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _clickOnNewButton = By.XPath("//*[@id='layout-header']/div[1]/div[1]/nav/ul/li[3]/a");
        
        private readonly By _newsPageTitleText = By.CssSelector(".article-level-1");

        private readonly By _firstNewsCard = By.XPath("(.//*[@id='posts-items-box']//a[@class = 'posts_item-title'])[position()=1]");

        private readonly By _thirdNewsCard = By.XPath("(.//*[@id='posts-items-box']//a[@class = 'posts_item-title'])[position()=1]");

        private readonly By _firstNewsPageTitleText = By.CssSelector(".page_title-text");
        private readonly By _thirdNewsPageTitleText = By.CssSelector(".article-level-1");

        private readonly By _fifthPageButton = By.XPath("//*[@id='post-navigation']/ul/li[6]/a");
                
        private readonly By _expectedTextOnFifthPage = By.XPath("(.//*[@id='posts-items-box']//a[@class = 'posts_item-title'])[position()=1]");
       
        public void ClickOnNewsButton()
        {
            _webDriver.FindElement(_clickOnNewButton).Click();
        }
        
        public string GetNewsPageTitle()
        {
            return _webDriver.FindElement(_newsPageTitleText).Text;
        }
        public void ClickOnFirstCard()
        {
            _webDriver.FindElement(_firstNewsCard).Click();
        }
        public void ClickOnThirdCard()
        {
            _webDriver.FindElement(_thirdNewsCard).Click();
        }
        public string GetFirstNewsTitle()
        {
            return _webDriver.FindElement(_firstNewsPageTitleText).Text;
        }
        public string GetThirdNewsTitle()
        {
            return _webDriver.FindElement(_thirdNewsPageTitleText).Text;
        }

        public void ClickOnFifthPageButton()
        {
            _webDriver.FindElement(_fifthPageButton).Click();
        }
        public string GetExpectedTextOnFifthPage()
        {
            return _webDriver.FindElement(_expectedTextOnFifthPage).Text;
        }
    }
}
