using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Author: Liberty

// This class will store the locator and methods for the home page

namespace Automation
{
    public class HomePage 
    {
        private IWebDriver driver;
        public IWebElement addConsultantButton => this.driver.FindElement(By.ClassName("add-button"));
        public Dictionary<string, IWebElement> practiceSelectorsDict;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.practiceSelectorsDict = new Dictionary<string, IWebElement>();
            this.practiceSelectorsDict.Add("All Practices", (this.driver.FindElement(By.Id("mat-radio-2"))));
            this.practiceSelectorsDict.Add("Applications & Cloud Technology", (this.driver.FindElement(By.Id("mat-radio-3"))));
            this.practiceSelectorsDict.Add("Digital Assurance & Testing", (this.driver.FindElement(By.Id("mat-radio-4"))));
            this.practiceSelectorsDict.Add("Digital Manufactoring", (this.driver.FindElement(By.Id("mat-radio-5"))));
            this.practiceSelectorsDict.Add("Digital Transformation", (this.driver.FindElement(By.Id("mat-radio-6"))));
            this.practiceSelectorsDict.Add("Insights & Data", (this.driver.FindElement(By.Id("mat-radio-7"))));
        }

        public void ClickAddNewConsultantButton(){
            addConsultantButton.Submit();
        }

        public void SelectPractice(IWebElement practiceSelectorsDictValue){
            practiceSelectorsDictValue.Click();
        }

        public void ClickConsultant(){

        }
    }
}