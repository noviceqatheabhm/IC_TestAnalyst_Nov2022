using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Utilities
{
    public class Wait
    {
        public void WaitForWebElement(IWebDriver driver) //no parameters passed
        {
            //EXPLICIT WAIT
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5)); //time is established as 5 seconds always
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("to be inserted"))); //will work only for this element xpath
                                                                                                                       //and the condition is element to be clickable
        }

        //using parameters under condition Element to be clickable
        public static void WaitForWebElementTobeClickable(IWebDriver driver, string locator, string locatorValue, int seconds) //we can define seconds
        {
            //we put locator to make our wait even more reusable. we can add if statement 
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                // Wait until something condition happens - define what that condition is - element clickable and which element it needs to wait for
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }
        //using parameters under condition element exists
        public static void WaitForWebElementToExist(IWebDriver driver, string locator, string locatorValue, int seconds) //we can define seconds
        {
            
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
        }

    }
}
