using SpecflowProject1.Drivers;
using OpenQA.Selenium;

using Newtonsoft.Json;

namespace SpecflowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification
{
    public class MarsProfilePageCertificationsMethods : CommonDriver
    {
        private IWebElement MarsProfilePageCertificationsTab => driver.FindElement(By.XPath("//*[@data-tab=\"fourth\" and contains(text(),'Certifications')]"));
        private IWebElement MarsProfilePageCertificationsAddNewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement MarsProfilePageCertificationsTabCertificateOrAward => driver.FindElement(By.XPath("//*[@class=\"certification-award capitalize\"]"));
        private IWebElement MarsProfilePageCertificationsTabCertificationFrom => driver.FindElement(By.XPath("//*[@class=\"received-from capitalize\"]"));
        private IWebElement MarsProfilePageCertificationsTabCertificationYear => driver.FindElement(By.XPath("//*[@name=\"certificationYear\"]"));
        private IWebElement MarsProfilePageCertificationsTabAddButton => driver.FindElement(By.XPath("//*[@value=\"Add\"]"));
        private IWebElement MarsProfilePageCertificationsTabCancelButton => driver.FindElement(By.XPath("//*[@value=\"Cancel\"]"));
        private IWebElement MarsProfilePageCertificationsTabEditButton => driver.FindElement(By.XPath("//*/tbody/tr/td[4]/span[1]/i"));
        private IWebElement MarsProfilePageCertificationsTabUpdateButton => driver.FindElement(By.XPath("//*[@value=\"Update\"]"));
        private IWebElement MarsProfilePageCertificationsTabDeleteButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]"));
        AssertNotify pa => new AssertNotify();

        public void marsProfilePageCertificationsAddClick()
        {
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@data-tab=\"fourth\" and contains(text(),'Certifications')]");
            MarsProfilePageCertificationsTab.Click();

        }
        public void marsProfilePageCertificationsAdd()
        {


            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\Certification.json");
            Certifications certifications = JsonConvert.DeserializeObject<Certifications>(dataJson);
            for (int i = 0; i < certifications.certifications.Count; i++)
            {
                try
                {
                    Certification cert = certifications.certifications.ElementAt(i);
                    MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");
                    MarsProfilePageCertificationsAddNewButton.Click();
                    Thread.Sleep(30);
                    MarsProfilePageCertificationsTabCertificateOrAward.SendKeys(cert.Certificate);
                    MarsProfilePageCertificationsTabCertificationFrom.SendKeys(cert.Institution);
                    MarsProfilePageCertificationsTabCertificationYear.SendKeys(cert.Year);
                    MarsProfilePageCertificationsTabAddButton.Click();
                    string compNoti = cert.Certificate + " has been added to your certification";
                    if (pa.assertNotification().Trim() == compNoti.Trim())
                    {

                        Console.WriteLine("Test " + i + " Successful");
                    }
                    else
                    {

                        Console.WriteLine("Test " + i + "  Not Successful and below message displayed");
                        Console.WriteLine(pa.assertNotification().Trim());
                    }
                }


                catch (NoSuchElementException)
                {
                }
            }
        }
        public void marsProfilePageCertificationsEdit()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\Certification.json");
            Certifications certifications = JsonConvert.DeserializeObject<Certifications>(dataJson);

            try
            {
                Certification cert = certifications.certifications.ElementAt(0);
                //cert.Certificate;
                MarsWait.WaitToBeClickable("XPath", 10, "//*/tbody/tr/td[4]/span[1]/i");
                MarsProfilePageCertificationsTabEditButton.Click();
                Thread.Sleep(30);
                MarsProfilePageCertificationsTabCertificateOrAward.Clear();
                MarsProfilePageCertificationsTabCertificateOrAward.SendKeys(cert.Certificate);
                MarsProfilePageCertificationsTabCertificationFrom.Clear();
                MarsProfilePageCertificationsTabCertificationFrom.SendKeys(cert.Institution);
                MarsProfilePageCertificationsTabCertificationYear.SendKeys(cert.Year);
                MarsProfilePageCertificationsTabUpdateButton.Click();

                string compNoti = cert.Certificate + " has been updated to your certification";
                if (pa.assertNotification().Trim() == compNoti.Trim())
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
            }

        }
        public void marsProfilePageCertificationsDelete()
        {
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@data-tab=\"fourth\" and contains(text(),'Certifications')]");
            MarsProfilePageCertificationsTab.Click();
            

            try
            {
                
                MarsProfilePageCertificationsTabDeleteButton.Click();
                

                

            }

            catch (NoSuchElementException)
            {
            }

        }

    }
}
