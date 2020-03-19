using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace Automation
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        
        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = SogetiUtils.InitDriver("Chrome", "C:\\webdriver");
        }

        // [TestCase("TestUser1")]
        [Test]
        public void PageLoads()
        {
            SogetiUtils.LoadWebPage(this.driver, "https://profile-ci-web.azurewebsites.net/consultants");
        }

        [Test]
        public void clickNewConsultant()
        {
            SogetiUtils.LoadWebPage(this.driver, "https://profile-ci-web.azurewebsites.net/consultants");
            HomePage homePageObj = new HomePage(driver);
            homePageObj.clickAddNewConsultantButton();
        }

        [OneTimeTearDown]
        public void Close()
        {
            // driver.Close();
        }
    }
}