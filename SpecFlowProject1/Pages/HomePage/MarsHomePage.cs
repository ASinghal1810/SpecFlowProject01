using SpecflowProject1.Drivers;
using OpenQA.Selenium;

namespace SpecflowProject1.Pages.HomePage
{
    public class MarsHomePage : CommonDriver
    {
        private IWebElement mListing => driver.FindElement(By.XPath("//*[@class=\"ui eight item menu\"]/a[3]"));
        private IWebElement dashboard => driver.FindElement(By.XPath("//*[@class= \"item\" and @href=\"/Account/Dashboard\" and text()='Dashboard']"));
        
        public void manageListingComponentButton()
        {
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@class=\"ui eight item menu\"]/a[3]");
            mListing.Click();

        }
        public void manageDashboardComponentButton()
        {
            
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@class= \"item\" and @href=\"/Account/Dashboard\" and text()='Dashboard']");
            dashboard.Click();
        }
    }
}
