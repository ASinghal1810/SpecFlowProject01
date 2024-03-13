using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowProject1.Drivers;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.Components.SearchSkillComponent
{
    public class MarsSearchSkills : MarsHook
    {
        private IWebElement marsLogo => marsDriver.FindElement(By.XPath("//a[@href=\"/\"]"));
        private IWebElement searchBarTextBox => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[3]/div/input"));
        private IWebElement searchButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[3]/div/button"));
        private IWebElement filterOnlineOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[1]"));
        private IWebElement filterOnsiteOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[2]"));
        private IWebElement filterShowAllOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[3]"));
        private IWebElement firstSkill => marsDriver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img"));
        private IWebElement locationType => marsDriver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]"));


        public void goToHomePage()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//a[@href=\"/\"]");
            marsLogo.Click();
        }

        public void searchByOnlineOption(string skillName1)
        {
            searchBarTextBox.SendKeys(skillName1);
            searchButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[1]");
            filterOnlineOption.Click();

        }
        public void searchByOnsiteOption(string skillName2)
        {
            searchBarTextBox.SendKeys(skillName2);
            searchButton.Click();

            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[2]");
            filterOnsiteOption.Click();
        }

        public void SelectTheFirstListing()
        {
            MarsWait.MarsWaitToBeClickable("XPath", 5, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img");
            firstSkill.Click();
        }

        public void assertLocationTypeAsOnline(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            MarsWait.MarsWaitToBeVisible("XPath", 5, "//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]");
            if (locationType.Text == "Online")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual Location Type and expected Location Type do not match!");
            }
        }

        public void assertLocationTypeAsOnSite(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            MarsWait.MarsWaitToBeVisible("XPath", 5, "//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]");
            if (locationType.Text == "On-Site")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Assert.Fail("Actual Location Type and expected Location Type do not match!");
            }
        }
    }
}
