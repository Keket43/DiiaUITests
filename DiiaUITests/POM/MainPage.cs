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

        private readonly By _arrowToTheLeft = //By.XPath("(.//*[@id='gromadyanam']//div[@class = 'swiper_services-btn-next swiper-btn-next'])");

        
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
        //как сравнить лучше???


        //сценарий 3

        //если нужна таже кнопка? 2 шага повторяються
        //public void ClickOnArrowToTheRightButton() 
        //{
        //    _webDriver.FindElement(_arrowToTheRight).Click();
        //}
        public void ClickOnArrowToTheLeftButton() 
        {
            _webDriver.FindElement(_arrowToTheLeft).Click();
        }
    }
}
