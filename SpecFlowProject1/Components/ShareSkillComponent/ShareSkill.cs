using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecflowProject1.Drivers;
using SpecFlowProject1.Drivers;
using Microsoft.VisualBasic.FileIO;
using AutoItX3Lib;

namespace SpecFlowProject1.Components.ShareSkillComponent
{
    internal class MarsShareSkills : MarsHook
    {
        private IWebElement shareSkillButton => marsDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
        private IWebElement titleTextBox => marsDriver.FindElement(By.Name("title"));
        private IWebElement descriptionTextArea => marsDriver.FindElement(By.Name("description"));
        private IWebElement categoryDropdownList => marsDriver.FindElement(By.Name("categoryId"));
        private IWebElement musicOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select/option[6]"));
        private IWebElement subcategoryDropdownList => marsDriver.FindElement(By.Name("subcategoryId"));
        private IWebElement voiceOverOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]"));
        private IWebElement firstTagsTextBox => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement secondTagsTextBox => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement oneoffOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        private IWebElement onsiteOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
        private IWebElement startDate => marsDriver.FindElement(By.Name("startDate"));
        private IWebElement endDate => marsDriver.FindElement(By.Name("endDate"));
        private IWebElement mondayOption => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
        private IWebElement startTime => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
        private IWebElement endTime => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
        private IWebElement tagTextbox => marsDriver.FindElement(By.XPath("//input[@class=\"ReactTags__tagInputField\"]"));
        private IWebElement skillExchangeTagTextBox => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement workSamples => marsDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement saveButton => marsDriver.FindElement(By.XPath("//input[@class=\"ui teal button\"]"));

        public void ClickTheShareSkillButton(string name)
        {
            MarsExtentReporting.MarsExtentReportingLogInfo(name);
            shareSkillButton.Click();
        }

        public void ShareSkillAction(string Title, string SKDescription, string Tag1, string Tag2, string StartDate, string EndDate, string StartTime, string EndTime, string SETag1, string SETag2)
        {

            MarsWait.MarsWaitToBeVisible("Name", 5, "title");
            // Identify the Title textbox and enter vaild title
            titleTextBox.SendKeys(Title);

            // Identify the Description textarea and enter description
            descriptionTextArea.SendKeys(SKDescription);

            // Identify the Category dropdown list and select Music & Audio
            categoryDropdownList.Click();
            musicOption.Click();

            // Identify the Category dropdown list and select the Subcategory
            subcategoryDropdownList.Click();
            // Select the Voice over option
            voiceOverOption.Click();

            // Identify the Tgas input a tag
            firstTagsTextBox.SendKeys(Tag1);
            firstTagsTextBox.SendKeys(Keys.Enter);

            secondTagsTextBox.SendKeys(Tag2);
            secondTagsTextBox.SendKeys(Keys.Enter);

            // Identify the Start date and End date then input value
            startDate.SendKeys(StartDate);
            endDate.SendKeys(EndDate);

            // Identify the Monday checkbox and click on it
            mondayOption.Click();

            // Identify the Monday start time box and end time box then input value
            startTime.SendKeys(StartTime);
            endTime.SendKeys(EndTime);

            // Identify the Skill-Exchange and input a tag
            skillExchangeTagTextBox.SendKeys(SETag1);
            skillExchangeTagTextBox.SendKeys(Keys.Enter);

            skillExchangeTagTextBox.SendKeys(SETag2);
            skillExchangeTagTextBox.SendKeys(Keys.Enter);

            // Identify the Work Samples and click the plus button to upload photo
            workSamples.Click();

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(2000);
            autoIt.Send("G:\\AdvancedTask(SepcFlow)\\AdvancedTask(Eddie)\\MarsSpecFlowAdvnTask\\MarsAdvancedTask(SpecFlow)\\MarsAdvancedTask(SpecFlow)\\TestData\\TestImage\\JazzImage.jpg");
            Thread.Sleep(1000);
            autoIt.Send("{ENTER}");


            // Identify the Save button and click on it
            saveButton.Click();
        }
    }
}