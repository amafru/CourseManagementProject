using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace CourseManagementProject.Pages
{
    class StudentPage
    {
        IWebDriver driver = new FirefoxDriver();

        public void StudentCreateNewLink()
        {
            driver.FindElement(By.XPath("//a[contains(.,'Create New')]"));
        }
        
        public void StudentFamilyName()
        {
            driver.FindElement(By.XPath("//input[contains(@data-val-required,'Last name is required')]"));
        }

        public void StudentFirstName()
        {
            driver.FindElement(By.XPath("//input[contains(@data-val-required,'First name is required')]"));
        }

        public void StudentEnrollmentDate()
        {
            driver.FindElement(By.XPath("//input[contains(@data-val-date,'The field Enrollment Date must be a date.')]"));
        }

        public void StudentCreateLink()
        {
            driver.FindElement(By.XPath("//input[contains(@value,'Create')]"));
        }


    }
}
