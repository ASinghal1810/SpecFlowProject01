using SpecflowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SpecFlowProject1.Pages;
using OpenQA.Selenium;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.Components.ProfileComponent
{
    public class MarsProfileDescription :MarsHook
    {
        private IWebElement descriptionPenIcon => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private IWebElement descriptionTextArea => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private IWebElement descriptionSaveButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));

        public void marsProfileDecriptionAdd(string description)
        {
            descriptionPenIcon.Click();
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys(description);
            descriptionSaveButton.Click();
        }

        public void marsProfileDecriptionEdit(string description)
        {
            descriptionPenIcon.Click();
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys(description);
            descriptionSaveButton.Click();
        }
    }
}
