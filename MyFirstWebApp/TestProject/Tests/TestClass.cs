using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.testapp.com/");

            Thread.Sleep(5000);

            driver.Quit();
        }
    }
}
