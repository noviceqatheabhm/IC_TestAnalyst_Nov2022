
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open browser
IWebDriver driver = new ChromeDriver();
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

if( helloHari.Text == "Hello hari!")
{ Console.WriteLine("The login is successful and the Test passed!"); }
else
{ Console.WriteLine("The login is not successful and the test failed"); }

// click on Adminstration and select Time and Materials
IWebElement adminbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminbutton.Click();
IWebElement tandm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tandm.Click();

Thread.Sleep(1000);

//click on create new button
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
Thread.Sleep(1000);
//Check if the entry is saved by checking the last page, last entry
IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastpage.Click();
IWebElement checklastrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (checklastrecord.Text == "Autotest")
{
    Console.WriteLine("Test passed, New record created successfully");
}
else
{   Console.WriteLine("Test failed, new record not created successfully");
}

//click on edit item
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();
// Edit Action 1: edit the code textbox to new value and save
IWebElement code = driver.FindElement(By.Id("Code"));
code.SendKeys("1");
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(1000);

//Test 1: check if edit is successful
IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPage.Click();
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

//click on delete item
