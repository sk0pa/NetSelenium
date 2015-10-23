using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using TestProject.PageObjects;
using System.Configuration;

namespace TestProject
{
    [TestFixture]
    public class LoginTest
    {

        String login;
        String password;
        private IWebDriver driver;

        [SetUp]
        public void Load_Driver()
        {
            driver = new FirefoxDriver();
        }

        [SetUp]
        public void Load_Config() {
            AppSettingsReader appSettingsReader = new AppSettingsReader();
            login = (string)appSettingsReader.GetValue("login", typeof(string));
            password = (string)appSettingsReader.GetValue("password", typeof(string));
        }

        [Test]
        public void Login_Test()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Enter_Login(login);
            loginPage.Enter_Password(password);
            MainPage mainPage = loginPage.Click_Enter_Button();
            mainPage.Check_Logo();
        }

        [TearDown]
        public void Tear_Down()
        {
            driver.Quit();
        }
    }
}
