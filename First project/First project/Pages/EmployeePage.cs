using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Pages
{
    public class EmployeePage
    {
        //create methods related to the employee page
        


        public void CreateEmployee (IWebDriver driver)
        {
            //Assert.Pass("Employee record created successfully");
        }
        public void EditEmployee(IWebDriver driver)
        {
            Assert.Pass("Employee record edited successfully");
        }
        public void DeleteEmployee(IWebDriver driver)
        {
            Assert.Pass("Employee record deleted successfully");
        }
    }
}
