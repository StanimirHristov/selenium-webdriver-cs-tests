using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Tests
{
    [TestClass]
    public class AbvTests
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
        public void CheckLoginWorks()
        {
            Driver.Navigate().GoToUrl("https://www.abv.bg/");

            AbvLoginPage LoginPage = new AbvLoginPage(Driver);
            AbvUserPage UserPage = new AbvUserPage(Driver);

            LoginPage.UserNameField.Clear();
            LoginPage.UserNameField.SendKeys("testobject");

            LoginPage.PasswordField.Clear();
            LoginPage.PasswordField.SendKeys("testobject1A");

            LoginPage.LoginButton.Click();

            Utilities.Waiting(5);

            Assert.AreEqual(@"testobject@abv.bg", UserPage.UserNameInHeader.Text);
        }

        [TestMethod]
        public void SortingMailsWorks()
        {
            Driver.Navigate().GoToUrl("https://www.abv.bg/");

            AbvLoginPage LoginPage = new AbvLoginPage(Driver);
            AbvUserPage UserPage = new AbvUserPage(Driver);

            LoginPage.UserNameField.Clear();
            LoginPage.UserNameField.SendKeys("testobject");

            LoginPage.PasswordField.Clear();
            LoginPage.PasswordField.SendKeys("testobject1A");

            LoginPage.LoginButton.Click();

            Utilities.Waiting(5);
            UserPage.MailBox.Click();
            Utilities.Waiting(1);
            UserPage.SortingMailsMenue.Click();
            Utilities.Waiting(1);
            UserPage.SortingMailsDateUpAndDownOptions.Click();
            Utilities.Waiting(1);
            UserPage.AbvLetterSelectedUp.Click();
            Utilities.Waiting(1);
            UserPage.MailBox.Click();
            Utilities.Waiting(1);
            UserPage.SelfLetterSelectedUp.Click(); Thread.Sleep(2000);

            UserPage.MailBox.Click();
            Utilities.Waiting(1);
            UserPage.SortingMailsMenue.Click();
            Utilities.Waiting(1);
            UserPage.SortingMailsDateUpAndDownOptions.Click();
            Utilities.Waiting(1);
            UserPage.AbvLetterSelectedDown.Click();
            Thread.Sleep(2000);
            UserPage.MailBox.Click();
            Utilities.Waiting(1);
            UserPage.SelfLetterSelectedDown.Click();
            Utilities.Waiting(1);
            UserPage.MailBox.Click();
            Utilities.Waiting(1);

            Assert.AreEqual(@"Екип АБВ", UserPage.AbvLetterSelectedDown.Text);
        }

        [TestMethod]
        public void CheckLogOutWorks()
        {
            Driver.Navigate().GoToUrl("https://www.abv.bg/");

            AbvLoginPage LoginPage = new AbvLoginPage(Driver);
            AbvUserPage UserPage = new AbvUserPage(Driver);
            AbvBbgLogoutPage GbgPage = new AbvBbgLogoutPage(Driver);

            LoginPage.UserNameField.Clear();
            LoginPage.UserNameField.SendKeys("testobject");

            LoginPage.PasswordField.Clear();
            LoginPage.PasswordField.SendKeys("testobject1A");

            LoginPage.LoginButton.Click();
            Utilities.Waiting(5);
            UserPage.UserNameInHeader.Click();
            UserPage.ExitButton.Click();
            Utilities.Waiting(5);

            Assert.IsTrue(Utilities.IsElementVisible(GbgPage.GbgHomePage));
        }
    }
}
