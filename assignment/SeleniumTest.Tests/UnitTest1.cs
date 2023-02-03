using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V109.CSS;

namespace SeleniumTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // DELETE
        // CREATE
        // EDIT --> match the delete for the next time it runs
        // VIEW



        [TestMethod]
        public void TestMethod1()
        {
            // This method tests creating a new customer
            string url = "https://localhost:44309//customers";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Marge Simpson");
            driver.FindElement(By.Id("Address")).SendKeys("Springfield");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        [TestMethod]
        public void TestMethod2()
        {
            // This method tests creating a new employee
            string url = "https://localhost:44309//employees";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Test");
            driver.FindElement(By.Id("Department")).SendKeys("Computing");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        [TestMethod]
        public void TestMethod3()
        {
            // This method tests creating a new service
            string url = "https://localhost:44309//services";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.Id("Name")).SendKeys("Test");

            // Select the dropdown option with the name test (this user was set in a previous test)
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("EmployeeID")));
            dropDown.SelectByText("Test");

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }



        [TestMethod]
        public void TestMethod4()
        {
            // This method tests editing a customer
            string url = "https://localhost:44309//customers";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Address")).Clear();

            driver.FindElement(By.Id("Name")).SendKeys("EditTest");
            driver.FindElement(By.Id("Address")).SendKeys("EditTest");

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        [TestMethod]
        public void TestMethod5()
        {
            // This method tests editing an employee
            string url = "https://localhost:44309//employees";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Department")).Clear();

            driver.FindElement(By.Id("Name")).SendKeys("EditTest");
            driver.FindElement(By.Id("Department")).SendKeys("EditTest");

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        [TestMethod]
        public void TestMethod6()
        {
            // This method tests editing a service
            string url = "https://localhost:44309//services";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Name")).SendKeys("EditTest");

            // Select the dropdown option with the name test (this user was set in a previous test)
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("EmployeeID")));
            dropDown.SelectByText("EditTest");

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }


        [TestMethod]
        public void TestMethod7()
        {
            // This method tests deleting a customer
            string url = "https://localhost:44309//customers";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        [TestMethod]
        public void TestMethod8()
        {
            // This method tests deleting a service
            string url = "https://localhost:44309//services";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }

        [TestMethod]
        public void TestMethod9()
        {
            // This method tests deleting an employee
            string url = "https://localhost:44309//employees";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }




        [TestMethod]
        public void TestMethod10()
        {
            // This method tests viewing a customer
            string url = "https://localhost:44309//customers";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Details")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Back to List")).Click();
        }


        [TestMethod]
        public void TestMethod11()
        {
            // This method tests viewing a service
            string url = "https://localhost:44309//services";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Details")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Back to List")).Click();
        }

        [TestMethod]
        public void TestMethod12()
        {
            // This method tests viewing an employee
            string url = "https://localhost:44309//employees";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Details")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Back to List")).Click();
        }



        // JOBS

        [TestMethod]
        public void TestMethod22()
        {
            // This method tests creating a job
            string url = "https://localhost:44309//jobs";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Select the dropdown option with the name test (this user was set in a previous test)
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("ServiceId")));
            dropDown.SelectByText("Test2");
            SelectElement dropDown2 = new SelectElement(driver.FindElement(By.Id("CustomerId")));
            dropDown2.SelectByText("EditTest");

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();





            // VIEW
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Details")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Back to List")).Click();






            // EDIT
            //driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Select the dropdown option with the name test (this user was set in a previous test)
            //SelectElement dropDown3 = new SelectElement(driver.FindElement(By.Id("ServiceId")));
            SelectElement dropDown3 = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control ServiceClass']")));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            dropDown3.SelectByText("Test3");

            //SelectElement dropDown4 = new SelectElement(driver.FindElement(By.Id("CustomerId")));
            SelectElement dropDown4 = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control CustomerClass']")));
            dropDown4.SelectByText("Test3");

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();





            // DELETE
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }


        //[TestMethod]
        //public void TestMethod23()
        //{
        //    // This method tests viewing an jobs
        //    string url = "https://localhost:44309//jobs";
        //    ChromeDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl(url);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    driver.FindElement(By.LinkText("Details")).Click();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    driver.FindElement(By.LinkText("Back to List")).Click();
        //}


        //[TestMethod]
        //public void TestMethod24()
        //{
        //    // This method tests editing a job
        //    string url = "https://localhost:44309//jobs";
        //    ChromeDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl(url);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    driver.FindElement(By.LinkText("Edit")).Click();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);

        //    // Select the dropdown option with the name test (this user was set in a previous test)
        //    SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("ServiceId")));
        //    dropDown.SelectByText("Test");
        //    SelectElement dropDown2 = new SelectElement(driver.FindElement(By.Id("CustomerId")));
        //    dropDown2.SelectByText("EditTest");

        //    driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        //}


        //[TestMethod]
        //public void TestMethod25()
        //{
        //    // This method tests deleting a job
        //    string url = "https://localhost:44309//jobs";
        //    ChromeDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl(url);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    driver.FindElement(By.LinkText("Delete")).Click();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        //    driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        //}
    }
}
