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
        IWebDriver driver;
   
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void DoMenuHover(By MenuSelector, int HoverSleepTimeInMilliSecs=4000)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(MenuSelector));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();

            if (HoverSleepTimeInMilliSecs > 0) { 
                System.Threading.Thread.Sleep(HoverSleepTimeInMilliSecs);
            }
        }

        public void DoMenuHoverThenClickMenuLink(By MenuSelector, string LinkText, int HoverSleepTimeInMilliSecs=4000)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(MenuSelector));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();

            if (HoverSleepTimeInMilliSecs > 0) {
                System.Threading.Thread.Sleep(HoverSleepTimeInMilliSecs);
            }

            IWait<IWebDriver> wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement subelement = wait2.Until(ExpectedConditions.ElementIsVisible(By.LinkText(LinkText)));
            action.MoveToElement(subelement);
            action.Click().Build().Perform();
        }
    }
}