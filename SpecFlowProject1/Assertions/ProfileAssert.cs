using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using OpenQA.Selenium;
using SpecflowProject1.Drivers;

namespace SpecFlowProject1.Assertions
{
    public class ProfileAssert : CommonDriver
    {
        private static IWebElement avail => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/span"));
        private static IWebElement hour => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));

        private static IWebElement et => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[4]/div/div[4]/div/span"));

        private static IWebElement notiText => driver.FindElement(By.XPath("/html/body/div[1]/div"));

        public string assertNotification()
        {
            MarsWait.WaitToBeVisible("XPath", 20, "/html/body/div[1]/div");

            return notiText.Text;
        }

    }
}