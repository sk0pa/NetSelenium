using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject.PageObjects
{
    class LoginPage
    {
        private IWebDriver driver;
        private const String LOGIN_FIELD = "//input[@id='email']";
        private const String PASSWORD_FIELD = "//input[@id='pass']";
        private const String ENTER_BUTTON = "//label[@id='loginbutton']";
        public const String FACEBOOK_URL = "https://www.facebook.com/";

        public LoginPage(IWebDriver driver) {
            this.driver = driver;
            driver.Navigate().GoToUrl(FACEBOOK_URL);
        }

        public void Enter_Login(String login)
        {
            driver.FindElement(By.XPath(LOGIN_FIELD)).SendKeys(login);
        }

        public void Enter_Password(String password)
        {
            driver.FindElement(By.XPath(PASSWORD_FIELD)).SendKeys(password);
        }

        public MainPage Click_Enter_Button()
        {
            driver.FindElement(By.XPath(ENTER_BUTTON)).Click();
            return new MainPage(driver);
        }
    }
}
