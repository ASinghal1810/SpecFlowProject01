using SpecflowProject1.Drivers;
using OpenQA.Selenium;

namespace SpecflowProject1.Pages.HomePage.Components.ManageListings
{
    public class IfBlock : CommonDriver
    {

        public void DaysIfBlock(IWebElement days, IWebElement daysST, IWebElement daysET, string day, string dayST, string dayET)
        {

            if (days.Selected)
            {
                if (day == "Active")
                {
                    daysST.SendKeys(dayST);
                    daysET.SendKeys(dayET);
                }
                else
                {
                    days.Click();
                    Thread.Sleep(50);
                    daysST.SendKeys(Keys.Delete);
                    daysST.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysST.SendKeys(Keys.Delete);
                    daysST.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysST.SendKeys(Keys.Delete);
                    Thread.Sleep(50);
                    daysET.SendKeys(Keys.Delete);
                    daysET.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysET.SendKeys(Keys.Delete);
                    daysET.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysET.SendKeys(Keys.Delete);
                    Thread.Sleep(50);
                }
            }
            else
            {
                if (day == "Active")
                {
                    days.Click();
                    daysST.SendKeys(dayST);
                    daysET.SendKeys(dayET);
                }
                else
                {

                    Thread.Sleep(50);
                    daysST.SendKeys(Keys.Delete);
                    daysST.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysST.SendKeys(Keys.Delete);
                    daysST.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysST.SendKeys(Keys.Delete);
                    Thread.Sleep(50);
                    daysET.SendKeys(Keys.Delete);
                    daysET.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysET.SendKeys(Keys.Delete);
                    daysET.SendKeys(Keys.Tab);
                    Thread.Sleep(50);
                    daysET.SendKeys(Keys.Delete);
                    Thread.Sleep(50);
                }
            }
        }
    }
}