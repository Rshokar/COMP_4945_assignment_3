using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;

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
    }
}
