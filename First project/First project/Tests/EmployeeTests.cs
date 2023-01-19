using First_project.Pages;
using First_project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTests : CommonDriver
    {
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
            homePageObj.GoToEmployee(driver);
        }

        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            EmployeePage employeeobj = new EmployeePage();
            employeeobj.CreateEmployee(driver);
        }
        [Test, Order(2)]

        public void EditEmployee_Test()
        {
            EmployeePage employeeobj = new EmployeePage();
            employeeobj.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            EmployeePage employeeobj = new EmployeePage();
            employeeobj.DeleteEmployee(driver);
        }

        [TearDown]
        public void Closedriver()
        {
            driver.Close();
        }

    }
}
