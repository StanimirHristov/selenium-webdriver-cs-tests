using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Tests
{
    class AbvLoginPage
    {
        private readonly IWebDriver driver;

        public AbvLoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "loginBut")]
        public IWebElement LoginButton { get; set; }

    }
}
