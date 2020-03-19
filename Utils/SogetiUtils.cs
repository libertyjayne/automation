using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;

namespace Automation
{
    public class SogetiUtils
    {
        public static HomePage LoadWebPage(IWebDriver driver, string Url, int TimeoutInSecs=10) 
        {
            driver.Url = Url;
            new WebDriverWait(
                driver, 
                TimeSpan.FromSeconds(TimeoutInSecs)
            ).Until(
                d => ((IJavaScriptExecutor) d).ExecuteScript("return document.readyState").Equals("complete")
            );
            HomePage HomePageObj = new HomePage(driver);
            return HomePageObj;
        }

        public static IWebDriver InitDriver(string DriverType, string DriverDirPath) 
        {
            IWebDriver driver;
            string[] ValidDriverTypes = {"FireFox", "Chrome"};
            
            if (DriverType == "FireFox") {
                driver = new FirefoxDriver(DriverDirPath);
            } else if (DriverType == "Chrome")  {
                driver = new ChromeDriver(DriverDirPath);
            } else {
                throw new System.ArgumentException($"Parameter 'DriverType' was provided the value \"{DriverType}\"; it must be one of: \"{string.Join("\", \"", ValidDriverTypes)}\"!");
            }

            driver.Manage().Window.Maximize();
            _ = driver.Manage().Timeouts().ImplicitWait;
            return driver;
        }    
    }
}