using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestProject.PageObjects
{
    class MainPage
    {
        IWebDriver driver;
        private const String LOGO_SECTION = "//a[contains(@href, 'logo')]";

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Check_Logo() {
            IWebElement logo = driver.FindElement(By.XPath(LOGO_SECTION));
            Assert.True(logo.Text.Contains("Facebook"));
        }
    }
}
