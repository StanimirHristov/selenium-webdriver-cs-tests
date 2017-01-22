using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    [TestClass]
    public class BtvNewsTests
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void InitializeTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            this.Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            this.Driver.Dispose();
        }

        [TestMethod]
        public void CheckLogInExists()
        {
            Driver.Navigate().GoToUrl("http://btvnovinite.bg/");

            BtvCommonPage commonPage = new BtvCommonPage(Driver);
            bool isLoginExists = commonPage.LogIn.Displayed;

            Assert.AreEqual(true, isLoginExists);
        }

        [TestMethod]
        public void CheckRegistrationWorks()
        {
            Driver.Navigate().GoToUrl("http://btvnovinite.bg/registration");

            BtvRegisterPage registerPage = new BtvRegisterPage(Driver);

            Random rnd = new Random();
            int acountNumber = rnd.Next(1, 1000000);
            string acountFinish = acountNumber.ToString();
            string userName = "TestUser" + acountFinish;
            string userEmail = userName + "@abv.bg";

            registerPage.UserNameField.Clear();
            registerPage.UserNameField.SendKeys(userName);

            registerPage.Password.Clear();
            registerPage.Password.SendKeys("TestUser2");

            registerPage.ConfirmPassword.Clear();
            registerPage.ConfirmPassword.SendKeys("TestUser2");

            registerPage.email.Clear();
            registerPage.email.SendKeys(userEmail);

            registerPage.name.Clear();
            registerPage.name.SendKeys("TestUser");

            registerPage.surname.Clear();
            registerPage.surname.SendKeys("TestUserson");

            registerPage.ManSex.Click();

            registerPage.SelectCountry("Буркина Фасо");

            //registerPage.SelectDistrict("София (област)");

            registerPage.SelectEducation("Средно");

            registerPage.SelectJob("Студент");

            registerPage.ConfirmRulesButton.Click();

            registerPage.SelectBirthday_day("4");

            registerPage.SelectBirthday_month("Април");

            registerPage.SelectBirthday_year("1982");

            registerPage.RegistrationButton.Click();
             
            Utilities.Waiting(10);

            string currentUrl = this.Driver.Url;
            Assert.AreEqual(@"http://btvnovinite.bg/", currentUrl);
        }


    }
}
