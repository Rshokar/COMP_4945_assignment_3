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
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Name")).SendKeys("EditTest");

            // Select the dropdown option with the name test (this user was set in a previous test)
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("EmployeeID")));
            dropDown.SelectByText("EditTest");

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }


        // ***NOT WORKING
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
    }
}
