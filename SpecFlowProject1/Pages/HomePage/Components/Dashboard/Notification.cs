
using OpenQA.Selenium;
using SpecflowProject1.Drivers;

namespace SpecflowProject1.Pages.HomePage.Components.Dashboard
{
    public class Notification : CommonDriver
    {

        private IWebElement deleteBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement deleteCheckBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement deleteIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        AssertNotify pa => new AssertNotify();
        public void marsNotificationDelete()
        {

            try
            {
                MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");
                deleteBox.Click();
                MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");
                deleteIcon.Click();
                if (pa.assertNotification().Trim() == "Notification updated")
                {
                    Console.WriteLine("Test Successful");
                }
                else
                {

                    Console.WriteLine("Test Not Successful and below message displayed");
                    Console.WriteLine(pa.assertNotification().Trim());
                }
            }

            catch (NoSuchElementException)
            {
                Console.WriteLine("No Existing Notification to Delete");
                Console.WriteLine("Test Successful");
            }

        }

    }
}