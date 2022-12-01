using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            // open URL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // Identify the username and enter the username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            // Identify the password and enter the password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            //dentify the loginbutton and click on it
            IWebElement loginKey = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginKey.Click();
            // check if the page navigates
            Thread.Sleep(1000);
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            { Console.WriteLine("The login is successful and the Test passed!"); }
            else
            { Console.WriteLine("The login is not successful and the test failed"); }


            Thread.Sleep(1000);

        }
    }
}
