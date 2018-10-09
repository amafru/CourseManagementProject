using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace CourseManagementProject.Pages
{
    class CoursePage
    {
        //This class contains locators for all elements e.g. 'CourseTitle' field and actions such as 'SendKeys', 'Click' etc for the Course Page...

        IWebDriver driver = new FirefoxDriver();

        public void GoToUrl()
        {
            driver.Navigate().GoToUrl("http://localhost/CourseManagementSystem/course");
            driver.Manage().Window.Maximize();
        }

        public void CourseCreateNewLink()
        {
            driver.FindElement(By.LinkText("Create New")).Click();
        }

        public void CourseNumberField(string CourseNumber)
        {
            driver.FindElement(By.XPath("//input[contains(@data-val-number,'The field Course Number must be a number.')]")).SendKeys(CourseNumber);
        }

        public void CourseTitleField(string CourseTitle)
        {
            driver.FindElement(By.XPath("//input[contains(@data-val-maxlength-max,'50')]")).SendKeys(CourseTitle);
        }

        public void CourseCreditsField(string CourseCredits)
        {
            driver.FindElement(By.XPath("//input[contains(@data-val-number,'The field Credits must be a number.')]")).SendKeys(CourseCredits);
        }

        public void DepartmentIDField(string DepartmentID)
        {
            driver.FindElement(By.Id("DepartmentId")).Click();
            new SelectElement(driver.FindElement(By.Id("DepartmentId"))).SelectByText(DepartmentID);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='DepartmentId'])[1]/following::option[2]")).Click();
        }

        public void CourseCreateButton()
        {
            driver.FindElement(By.XPath("//input[contains(@value,'Create')]")).Click();
        }


    }
}
