using SpecflowProject1.Drivers;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecflowProject1.Pages.HomePage.Components.Profile
{
    public class ProfileMethods : CommonDriver
    {
        private IWebElement location => driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[1]/div/span/i"));
        private IWebElement availability => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private IWebElement hours => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private IWebElement earnTarget => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        AssertNotify pa => new AssertNotify();

        public void profileEditButtonLoc()
        {

            location.Click();

        }

        public void profileEditButtonAvailability(int i)
        {

            Thread.Sleep(500);
            availability.Click();
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\Availability.json");
            Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
            Profile profile = profiles.profileAvailability.ElementAt(i);
            SelectElement selavail = new SelectElement(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select")));
            selavail.SelectByText(profile.Availability);

            //if (pa.assertNotification().Trim() == "Availability updated")
            //{
            //    Console.WriteLine("Test Successful");
            //}
            //else
            //{

            //    Console.WriteLine("Test Not Successful and below message displayed");
            //    Console.WriteLine(pa.assertNotification().Trim());
            //}
        }
        public void profileEditButtonHours(int i)
        {
            Thread.Sleep(500);
            hours.Click();
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\Hours.json");
            Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
            Profile profile = profiles.profileHours.ElementAt(i);
            SelectElement selhr = new SelectElement(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select")));
            selhr.SelectByText(profile.Hours);
            //if (pa.assertNotification().Trim() == "Availability updated")
            //{
            //    Console.WriteLine("Test Successful");
            //}

            //else
            //{

            //    Console.WriteLine("Test Not Successful and below message displayed");
            //    Console.WriteLine(pa.assertNotification().Trim());
            //}
        }
        public void profileEditButtonEarnTarget(int i)
        {
            Thread.Sleep(500);
            earnTarget.Click();
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\EarnTarget.json");
            Profiles profiles = JsonConvert.DeserializeObject<Profiles>(dataJson);
            Profile profile = profiles.profileEarnTarget.ElementAt(i);
            SelectElement selET = new SelectElement(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select")));
            selET.SelectByText(profile.EarnTarget);
            //pa.profileET();
            //if (pa.assertNotification().Trim() == "Availability updated")
            //{
            //    Console.WriteLine("Test Successful");
            //}
            //else
            //{

            //    Console.WriteLine("Test Not Successful and below message displayed");
            //    Console.WriteLine(pa.assertNotification().Trim());
            //}

        }

    }
}

