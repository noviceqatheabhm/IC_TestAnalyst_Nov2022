using First_project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            IWebElement create = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            create.Click();

            // Identify the Typecode dropdown box and select Time
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            IWebElement Time = driver.FindElement(By.XPath("/html/body/div[5]"));
            Time.Click();

            //Identify the Code textbox and enter the text
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Autotest");

            // Identify the description textbox and enter the description
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("Description");

            //Identify the price textbox and enter the price per unit
            IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            //IWebElement price = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]"));
            //IWebElement price = driver.FindElement(By.Id("Price"));
            price.SendKeys("100");

            //Identify the select box and click on save
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();

            //Thread.Sleep(5000);
            //using EXPLICIT WAIT instead of thread.sleep 
                //var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            // FLUENT WAIT
            Wait.WaitForWebElementTobeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);

            //Check if the entry is saved by checking the last page, last entry
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpage.Click();
            IWebElement checklastrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (checklastrecord.Text == "Autotest")
            {
                Console.WriteLine("Test passed, New record created successfully");
            }
            else
            {
                Console.WriteLine("Test failed, new record not created successfully");
            }
        }
        public void EditTM(IWebDriver driver) 
        {
            //click on edit item
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(10000);
            // Edit Action 1: edit the code textbox to new value and save
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("1");
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            //Test 1: check if edit is successful
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(10000);
            IWebElement checkLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (checkLastRecord.Text == "Autotest1")
            {
                Console.WriteLine("Test passed, Successfully edited to Autotest1");
            }
            else
            {
                Console.WriteLine("Test failed, Edit to Autotest1 not successful");
            }

            //Edit Action 2: to delete the code entry and add completely new value to code textbox
            IWebElement edittwiceButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            edittwiceButton.Click();
            driver.FindElement(By.Id("Code")).Clear();
            driver.FindElement(By.Id("Code")).SendKeys("newAutoTest");
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1000);
            //Test 2: check if your entry to code textbox is the same as the new value
            //go to last page
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            IWebElement checkLastrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (checkLastrecord.Text == "newAutoTest")
            {
                Console.WriteLine("Test passed, Successfuly edited to newAutotest.");
            }
            else
            {
                Console.WriteLine("Test failed, Edit to newAutotest failed, not successful");
            }

        }
        public void DeleteTM(IWebDriver driver) 
        {
            //click on delete item
            IWebElement deletebox = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[2]"));
            deletebox.Click();
            driver.SwitchTo().Alert().Accept();

            //to check if the item has been deleted
            if (checkLastrecord.Text == "newAutoTest")
            { Console.WriteLine("Record not deleted, Test failed"); }
            else
            { Console.WriteLine("Record deleted successfully"); }

        }

    }
}
