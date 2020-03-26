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

// This class will store the locator and methods for the consultant proile page

namespace Automation
{
    public class ConsultantProfilePage
    {
        IWebDriver driver;
        public Dictionary<string, IWebElement> consultantDict;

        public ConsultantProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            this.consultantDict = new Dictionary<string, IWebElement>();
            this.consultantDict.Add("lastName", (this.driver.FindElement(By.CssSelector("input[placeholder='Last Name*']"))));
            this.consultantDict.Add("firstName", (this.driver.FindElement(By.CssSelector("input[placeholder='First Name*']"))));
            this.consultantDict.Add("status", (this.driver.FindElement(By.CssSelector("input[placeholder='Company / organization*']"))));
            this.consultantDict.Add("phone", (this.driver.FindElement(By.CssSelector("input[placeholder='Phone Number']"))));
            this.consultantDict.Add("title", (this.driver.FindElement(By.CssSelector("input[placeholder='Job Title*']"))));
            this.consultantDict.Add("practice", (this.driver.FindElement(By.CssSelector("select[placeholder='Position / Level*']"))));
            this.consultantDict.Add("email", (this.driver.FindElement(By.CssSelector("input[placeholder='Email*']"))));
            this.consultantDict.Add("summary", (this.driver.FindElement(By.CssSelector("select[placeholder='Industry*']"))));
        }


        // public void SetEntryFieldText(string FieldCode, string FieldText, int SleepTimeInMilliSecs=0)
        // {
        //     IWebElement ContactIFrame = this.driver.FindElement(this.PageSelectors["ContactInfoIFrame"]);
        //     this.driver.SwitchTo().Frame(ContactIFrame);
            
        //     IWait<IWebDriver> wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        //     IWebElement FieldElt = wait.Until(ExpectedConditions.ElementIsVisible(this.PageSelectors[FieldCode]));

        //     FieldElt.SendKeys(FieldText);

        //     this.driver.SwitchTo().DefaultContent();

        //     if (SleepTimeInMilliSecs > 0) {
        //         Thread.Sleep(SleepTimeInMilliSecs);
        //     } 
        // }


        // public string GetEntryFieldText(string FieldCode)
        // {
        //     IWebElement ContactIFrame = this.driver.FindElement(this.PageSelectors["ContactInfoIFrame"]);
        //     this.driver.SwitchTo().Frame(ContactIFrame);
            
        //     IWait<IWebDriver> wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        //     IWebElement FieldElt = wait.Until(ExpectedConditions.ElementIsVisible(this.PageSelectors[FieldCode]));

        //     string FieldText = FieldElt.GetAttribute("value");

        //     this.driver.SwitchTo().DefaultContent();

        //     return FieldText;
        // }


        // public void SelectDropdownValue(string FieldCode, string FieldText, int SleepTimeInMilliSecs=0)
        // {
        //     Thread.Sleep(SleepTimeInMilliSecs); 
        //     IWebElement ContactIFrame = this.driver.FindElement(this.PageSelectors["ContactInfoIFrame"]);
        //     this.driver.SwitchTo().Frame(ContactIFrame);
            
        //     IWait<IWebDriver> wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        //     IWebElement FieldElt = wait.Until(ExpectedConditions.ElementIsVisible(this.PageSelectors[FieldCode]));

        //     SelectElement dropdownSelector = new SelectElement(FieldElt);
        //     dropdownSelector.SelectByText(FieldText);

        //     this.driver.SwitchTo().DefaultContent();

        //     Thread.Sleep(SleepTimeInMilliSecs); 
        // }


        public string GetDropdownValue(string FieldCode)
        {
            IWebElement ContactIFrame = this.driver.FindElement(this.PageSelectors["ContactInfoIFrame"]);
            this.driver.SwitchTo().Frame(ContactIFrame);
            
            IWait<IWebDriver> wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            IWebElement dropdownElt = wait.Until(ExpectedConditions.ElementIsVisible(this.PageSelectors[FieldCode]));

            SelectElement dropdownSelector = new SelectElement(dropdownElt);
            string SelectedValue = dropdownSelector.SelectedOption.Text;

            this.driver.SwitchTo().DefaultContent();

            return SelectedValue;
        }
    }
}