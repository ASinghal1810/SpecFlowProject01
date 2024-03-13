using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowProject1.Drivers;
using SpecFlowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class MarsManageListings : MarsHook
    {
        private IWebElement manageListingsTag => marsDriver.FindElement(By.XPath("//*[@href=\"/Home/ListingManagement\"]"));
        private IWebElement titleName => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private IWebElement deleteFirstListing => marsDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]"));
        private IWebElement deleteYesOption => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        private IWebElement deleteNoOption => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]"));
        private IWebElement deletedMessage => marsDriver.FindElement(By.XPath("/html/body/div[1]/div"));

        public void ClickManageListingsTag()
        {
            manageListingsTag.Click();
        }

        public void marsDeleteListing(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            MarsWait.MarsWaitToBeVisible("XPath", 10, "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]");
            if (titleName.Text == "Jazz Club")
            {
                deleteFirstListing.Click();
                deleteYesOption.Click();
            }
            else
            {
                Assert.Fail("Actual listing and expected listing do not match!");
            }
        }
    }
}