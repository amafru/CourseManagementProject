using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using CourseManagementProject.Pages;

namespace CourseManagementProject.Tests.CourseTab
{
    class CoursePageTests
    {
        [Test]
        public void CreateNewCourse1()
        {

            //reference the webdriver to be used
            IWebDriver driver = new FirefoxDriver();

            //we create a new Coursepage object called 'CreateNewCourse1' to exercise the happy path
            //For convenience of test case naming, I've also called his happy path test case create new 
            CoursePage CreateNewCourse1 = new CoursePage();

            //Test case body
            CreateNewCourse1.GoToUrl();
            CreateNewCourse1.CourseCreateNewLink();
            CreateNewCourse1.CourseNumberField("1");
            CreateNewCourse1.CourseTitleField("Biology");
            CreateNewCourse1.CourseCreditsField("3");
            CreateNewCourse1.DepartmentIDField("Biology");
            CreateNewCourse1.CourseCreateButton();



        }
    }
}
