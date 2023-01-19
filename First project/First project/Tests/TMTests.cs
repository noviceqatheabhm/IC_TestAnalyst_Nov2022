using First_project.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using First_project.Utilities;

namespace First_project.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TMTests : CommonDriver
    {

        //Create different methods here and we are going to get our code inside these methods
        //add NUnit package Annotations before each method

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            //steps for Setup: Login and go to TM page
            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home Page object initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTM(driver);
        }

        [Test, Order(1)]
        public void CreateTM_Tests() //these tests are completely independent
        {
           // TMPage tmPageobj = new TMPage();
            //tmPageobj.CreateTM(driver);
        }

        [Test, Order(2)]
        public void EditTM_Tests()
        {
            //TMPage tmPageobj = new TMPage();        
            //tmPageobj.EditTM(driver);
            
        }

        [Test, Order(3)]
        public void DeleteTM_Tests()
        {
            //TMPage tmPageobj = new TMPage();
            //tmPageobj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
             driver.Quit();
        }




        //open browser
        //IWebDriver driver = new ChromeDriver();



        //TM page object initialization and definition - one initialisation of object for all - they are within one class. 
            //TMPage tmPageobj = new TMPage();
            //tmPageobj.CreateTM(driver);
            //tmPageobj.EditTM(driver);
            //tmPageobj.DeleteTM(driver);


    }
}
