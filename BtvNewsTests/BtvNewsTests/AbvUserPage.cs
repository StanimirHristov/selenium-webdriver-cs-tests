using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Tests
{
    class AbvUserPage
    {
        private readonly IWebDriver driver;

        public AbvUserPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Id, Using = "gwt-uid-376")]
        public IWebElement UserNameInHeader { get; set; }

        [FindsBy(How = How.Id, Using = "gwt-uid-49")]
        public IWebElement SortingMailsMenue { get; set; }

        [FindsBy(How = How.Id, Using = "gwt-uid-51")]
        public IWebElement SortingMailsDateUpAndDownOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='inboxTable']/tbody[1]/tr[1]/td[2]/div[.='Екип АБВ']")]
        public IWebElement AbvLetterSelectedUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='inboxTable']/tbody[1]/tr[2]/td[2]/div[.='Sevdalin Valentinov']")]
        public IWebElement SelfLetterSelectedUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='inboxTable']/tbody[1]/tr[2]/td[2]/div[.='Екип АБВ']")]
        public IWebElement AbvLetterSelectedDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='inboxTable']/tbody[1]/tr[1]/td[2]/div[.='Sevdalin Valentinov']")]
        public IWebElement SelfLetterSelectedDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/div[4]/div/div[4]/div/div[2]/div/div[2]/div/div[4]/div/div[2]/div/div/div/table/tbody[1]/tr[1]/td/div")]
        public IWebElement MailBox { get; set; }

        [FindsBy(How = How.Id, Using = "gwt-uid-379")]
        public IWebElement ExitButton { get; set; }
    }
}