using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SpecflowProject1.Drivers
{
    [TestFixture]
    public class CommonDriver
    {

        public static IWebDriver driver;


        [SetUp]
        public void DriverStartWebsite()
        {
            

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            
        }


        [TearDown]
        public void DriverCloseBrowser()
        {
            //DriverEndTest();
            driver.Quit();
        }

        public void DriverEndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            //var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    break;
                case TestStatus.Skipped:
                    break;
                default:
                    break;
            }

        }
    }
}