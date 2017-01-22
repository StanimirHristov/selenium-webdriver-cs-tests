using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Tests
{
    class BtvCommonPage
    {
        private readonly IWebDriver driver;

        public BtvCommonPage(IWebDriver driver)
        {
            this.driver = driver; 
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "redirect-to-login-page")]
        public IWebElement LogIn { get; set; }
    }
}
