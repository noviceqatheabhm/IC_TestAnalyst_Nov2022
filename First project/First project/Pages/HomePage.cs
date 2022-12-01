using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Pages
{
    public class HomePage
    {
        public void GoToTM(IWebDriver driver)
        {
            // click on Adminstration and select Time and Materials
            IWebElement adminbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminbutton.Click();
            IWebElement tandm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tandm.Click();
        }
    }
}
