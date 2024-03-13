using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowProject1.Components.LoginComponent;
using TechTalk.SpecFlow;
using SpecflowProject1.Drivers;

namespace SpecFlowProject1.Drivers
{
    [TestFixture]
    public class MarsHook
    {
        public static IWebDriver marsDriver;
        protected MarsBroswer marsBroswer;


        [BeforeScenario(Order = 0)]
        public void MarsDriverStartWebsite()
        {
            MarsExtentReporting.MarsExtentReportingCreateTest(TestContext.CurrentContext.Test.MethodName);
            marsDriver = new ChromeDriver();
            marsDriver.Manage().Window.Maximize();
            marsDriver.Navigate().GoToUrl("http://localhost:5000/");

            marsBroswer = new MarsBroswer(marsDriver);
        }

        [BeforeScenario(Order = 1)]
        public void UserData()
        {
            var jsonPath = File.ReadAllText(@"G:\AdvancedTask(SepcFlow)\AdvancedTask(Eddie)\MarsSpecFlowAdvnTask\MarsAdvancedTask(SpecFlow)\MarsAdvancedTask(SpecFlow)\TestData\LoginData\UserData.json");
            var userData = JsonConvert.DeserializeObject<UserData>(jsonPath);

            ScenarioContext.Current.Set(userData, "UserData");
        }

        [AfterScenario]
        public void MarsDriverCloseBrowser()
        {
            MarsDriverEndTest();
            MarsExtentReporting.MarsExtentReportingEndReporting();
            marsDriver.Quit();
        }

        private void MarsDriverEndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    MarsExtentReporting.MarsExtentReportingLogFail($"Test has failed {message}");
                    break;
                case TestStatus.Skipped:
                    MarsExtentReporting.MarsExtentReportingLogInfo($"Test skipped {message}");
                    break;
                default:
                    break;
            }

            MarsExtentReporting.MarsExtentReportingLogScreenShot("Ending test", marsBroswer.MarsBroswerGetScreenShot());
        }
    }
}