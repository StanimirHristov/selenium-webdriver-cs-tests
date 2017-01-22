using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Tests
{
    class AbvBbgLogoutPage
    {
        private readonly IWebDriver driver;

        public AbvBbgLogoutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='wrapper']//div[@class='container headSearch']")]
        public IWebElement GbgHomePage { get; set; }

    }
}
