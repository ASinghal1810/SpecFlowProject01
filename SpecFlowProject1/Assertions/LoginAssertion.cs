
using SpecflowProject1.Drivers;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SpecflowProject1.Pages.MasterPage.Login;

namespace SpecFlowProject1.Assertions
{
    public class LoginAssertion : CommonDriver
    {
        private static IWebElement LogoutText => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
        private static IWebElement Logout => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
        //public LoginAssertion()
        //{
        //    LogoutText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
        //    Logout =  driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
        //}

        public void AssertLogin(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\New folder (2)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);
            Thread.Sleep(5000);
            try
            {


                if (LogoutText.Text == "Sign Out")
                {

                    if (user.ExpectedResult == "Success")
                    {
                        i++;
                        Console.WriteLine("Test 1." + i + " is Successfull");
                        Logout.Click();
                    }
                    else
                    {
                        i++;
                        Console.WriteLine("Test 1.", i, " is Unsuccessfull");
                        Logout.Click();
                    }

                }
            }
            catch (NoSuchElementException)
            {
                if (user.ExpectedResult == "Success")
                {
                    i++;
                    Console.WriteLine("Test 1." + i + " is Unsuccessfull");
                    driver.Navigate().Refresh();
                }
                else
                {
                    i++;
                    Console.WriteLine("Test 1." + i + " is Successfull");
                    driver.Navigate().Refresh();
                }


            }

        }
    }
}
