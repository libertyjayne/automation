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
        public IWebDriver driver;
        public Dictionary<string, IWebElement> consultantDict;
        public ConsultantProfilePage(IWebDriver driver)
        {
            this.driver = driver;

            // this.consultantDict = new Dictionary<string, IWebElement>();
            // this.consultantDict.Add("lastName", (this.driver.FindElement(By.CssSelector("//app-consultant-header/section/h1/p[1]/span[2]"))));
            // this.consultantDict.Add("firstName", (this.driver.FindElement(By.XPath("/html/body/app-root/section/app-consultant-view/app-consultant-header/section/h1/p[1]/span[1]"))));
            // this.consultantDict.Add("status", (this.driver.FindElement(By.CssSelector("input[placeholder='Company / organization*']"))));
            // this.consultantDict.Add("phone", (this.driver.FindElement(By.CssSelector("input[placeholder='Phone Number']"))));
            // this.consultantDict.Add("title", (this.driver.FindElement(By.CssSelector("input[placeholder='Job Title*']"))));
            // this.consultantDict.Add("practice", (this.driver.FindElement(By.CssSelector("select[placeholder='Position / Level*']"))));
            // this.consultantDict.Add("email", (this.driver.FindElement(By.CssSelector("input[placeholder='Email*']"))));
            // this.consultantDict.Add("summary", (this.driver.FindElement(By.CssSelector("select[placeholder='Industry*']"))));
        }

    }
}