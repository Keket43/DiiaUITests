using OpenQA.Selenium;


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

        private readonly By _arrowToTheRight = By.XPath("(.//*[@id='gromadyanam']//div[@class = 'swiper_services-btn-next swiper-btn-next'])");

        private readonly By _popularServicesSlideActive = By.CssSelector("[id='gromadyanam'] [class^='swiper-slide swiper_services-slide']");
        
        private readonly By _clikLeftButton = By.CssSelector("[class='swiper_services-btn-prev swiper-btn-prev']");

        private readonly By _movedOneLeft = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[2]/div[4]/div[1]/div/a");


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

        //сценарий 2
        public void ClickOnArrowToTheRightButton()
        {
            _webDriver.FindElement(_arrowToTheRight).Click();
        }

        public bool CheckActivenessOfMenu() =>
            _webDriver.FindElements(_popularServicesSlideActive)[0].GetAttribute("class").Contains("active");


        //сценарий 3

        public MainPage ClickToTheLeftSide()
        {
            _webDriver.FindElement(_clikLeftButton).Click();
            return this;
        }

        public string MovedToTheLeft() =>
           _webDriver.FindElement(_movedOneLeft).Text;
    }
}
