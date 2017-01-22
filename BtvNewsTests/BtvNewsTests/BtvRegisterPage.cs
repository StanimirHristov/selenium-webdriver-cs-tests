using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests
{
    class BtvRegisterPage
    {
        private readonly IWebDriver driver;

        public BtvRegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Id, Using = "visitor-registration-username")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='wrapper-visitor-sex']//div[@class='sex-title' and .='Жена']")]
        public IWebElement WomanSex { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='wrapper-visitor-sex']//div[@class='sex-title' and .='Мъж']")]
        public IWebElement ManSex { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-registration-password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-registration-password-confirmation")]
        public IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-country")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-registration-email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-registration-name")]
        public IWebElement name { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-registration-surname")]
        public IWebElement surname { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-district")]
        public IWebElement District { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-education")]
        public IWebElement Education { get; set; }

        [FindsBy(How = How.Id, Using = "visitor-position")]
        public IWebElement Job { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='visitor-registration-condition-button']//span")]
        public IWebElement ConfirmRulesButton { get; set; }

        [FindsBy(How = How.Id, Using = "registration-btn")]
        public IWebElement RegistrationButton { get; set; }

        [FindsBy(How = How.Id, Using = "birthday-day")]
        public IWebElement Birthday_day { get; set; }

        [FindsBy(How = How.Id, Using = "birthday-month")]
        public IWebElement Birthday_month { get; set; }

        [FindsBy(How = How.Id, Using = "birthday-year")]
        public IWebElement Birthday_year { get; set; }




        public void SelectCountry(string country)
        {
            SelectElement select = new SelectElement(Country);
            select.SelectByText(country);
        }

        public void SelectDistrict(string district)
        {
            SelectElement select = new SelectElement(District);
            select.SelectByText(district);
        }

        public void SelectEducation(string education)
        {
            SelectElement select = new SelectElement(Education);
            select.SelectByText(education);
        }

        public void SelectJob(string job)
        {
            SelectElement select = new SelectElement(Job);
            select.SelectByText(job);
        }

        public void SelectBirthday_day(string value)
        {
            SelectElement select = new SelectElement(Birthday_day);
            select.SelectByText(value);
        }

        public void SelectBirthday_month(string value)
        {
            SelectElement select = new SelectElement(Birthday_month);
            select.SelectByText(value);
        }

        public void SelectBirthday_year(string value)
        {
            SelectElement select = new SelectElement(Birthday_year);
            select.SelectByText(value);
        }

    }
}
