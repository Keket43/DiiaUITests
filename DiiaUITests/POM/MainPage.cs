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

        private readonly By _arrowToTheLeft = //By.XPath("(.//*[@id='gromadyanam']//div[@class = 'swiper_services-btn-next swiper-btn-prev'])");
        
        private readonly By _searchInputField = By.CssSelector(".input form-search_input");

        private readonly By _enterButton = By.CssSelector(".btn btn_search-main");
                

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

        //public string CheckActivenessOfMenu()
        //{
        //    return _webDriver.FindElement(_servicesHeaderMenuDropDownLink).GetAttribute("class").Contains("active") ? "active" : "inactive";
        //}
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


        //сценарий 1 , по модулю Поиск
        public void ClickOnSearchField(string validSearch)
        {
            _webDriver.FindElement(_searchInputField).SendKeys(validSearch);
        }
        public void ClickOnEnterButton()
        {
            _webDriver.FindElement(_enterButton).Click();
        }

        //сценарий 2 , по модулю Поиск
        //public void ClickOnSearchField()
        //{
        //    _webDriver.FindElement(_searchInputField).Click();
        //}
        //public void ClickOnEnterButton()
        //{
        //    _webDriver.FindElement(_enterButton).Click();
        //}

    }
}
