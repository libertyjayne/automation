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
        
        [SetUp]
        public void Setup()
        {
            this.driver = SogetiUtils.InitDriver("Chrome", "C:\\webdriver");
        }

        // [TestCase("All")]
        // [TestCase("ACT")]
        [Test]
        public void TestPracticeSelection(string practiceSelection)
        {
            SogetiUtils.LoadWebPage(this.driver, "https://profile-ci-web.azurewebsites.net/consultants");
            HomePage homePageObj = new HomePage(driver);
            homePageObj.SelectPractice(homePageObj.practiceSelectorsDict[practiceSelection]);
        }

        // [Test]
        // public void TestClickNewConsultant()
        // {
        //     Debug.WriteLine("my text message");
        //     SogetiUtils.LoadWebPage(this.driver, "https://profile-ci-web.azurewebsites.net");
        //     HomePage homePageObj = new HomePage(driver);
        //     homePageObj.clickAddNewConsultantButton();
        //     homePageObj.Equals ("https://profile-ci-web.azurewebsites.net/consultant");
        //     Thread.Sleep(5000);  
        // }

        // [Test]
        // public void TestHomePageLoads()
        // {
        //     SogetiUtils.LoadWebPage(this.driver, "https://profile-ci-web.azurewebsites.net/consultants");
        // }

        // [TearDown]
        // public void Close()
        // {
        //     driver.Close();
        // }
    }
}