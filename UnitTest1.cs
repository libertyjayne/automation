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
        HomePage homePageObj;
        string homePageURL = "https://profile-ci-web.azurewebsites.net/consultants";
        string consultantPageURL = "https://profile-ci-web.azurewebsites.net/consultant";
        
        [SetUp]
        public void Setup()
        {
            this.driver = SogetiUtils.InitDriver("Chrome", "C:\\webdriver");
            SogetiUtils.LoadWebPage(this.driver, homePageURL);
            this.homePageObj = new HomePage(this.driver);
        }
        
        [Test]
        public void TestHomePageLoads()
        {
            Assert.That(driver.Url.Equals (homePageURL));
        }

        [TestCase("Applications & Cloud Technology")]
        [TestCase("Digital Assurance & Testing")]
        [TestCase("Digital Manufactoring")]
        [TestCase("Digital Transformation")]
        [TestCase("Insights & Data")]
        public void TestPracticeSelection(string practiceSelectorsDictKey)
        {
            homePageObj.SelectPractice(homePageObj.practiceSelectorsDict[practiceSelectorsDictKey]);
        }

        [Test]
        public void TestClickNewConsultant()
        {
            homePageObj.ClickAddNewConsultantButton();
            Assert.That(homePageObj.Equals (consultantPageURL));
        }


        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}