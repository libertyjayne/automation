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
        public Dictionary<string, By> PageSelectors;

        public ConsultantProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            this.PageSelectors = new Dictionary<string, By>();
            this.PageSelectors.Add("FirstName", By.CssSelector("input[placeholder='First Name*']"));
            this.PageSelectors.Add("LastName", By.CssSelector("input[placeholder='Last Name*']"));
            this.PageSelectors.Add("JobTitle", By.CssSelector("input[placeholder='Job Title*']"));
            this.PageSelectors.Add("Email", By.CssSelector("input[placeholder='Email*']"));
            this.PageSelectors.Add("PhoneNumber", By.CssSelector("input[placeholder='Phone Number']"));
            this.PageSelectors.Add("Company", By.CssSelector("input[placeholder='Company / organization*']"));
            this.PageSelectors.Add("Industry", By.CssSelector("select[placeholder='Industry*']"));
            this.PageSelectors.Add("Position", By.CssSelector("select[placeholder='Position / Level*']"));
            this.PageSelectors.Add("Relationship", By.CssSelector("select[placeholder='Relationship with Sogeti*']"));
            this.PageSelectors.Add("ThisIsRegarding", By.CssSelector("select[placeholder='This is regarding a RFI/RFP*']"));
            this.PageSelectors.Add("YourMessage", By.CssSelector("textarea[placeholder='Your Message*']"));
            this.PageSelectors.Add("ContactInfoIFrame", By.CssSelector("iframe[height='500']"));
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