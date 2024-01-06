using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowProject1.Drivers;
using SpecflowProject1.Pages.HomePage.Components.Profile;
using SpecflowProject1.Pages.MasterPage;
using SpecflowProject1.Pages.MasterPage.Login;
using SpecFlowProject1.Assertions;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Pages.HomePage.Components.Profile
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        MarsMasterPage marsMstrPgObj => new MarsMasterPage();
        LoginMethodPassword LoginMethodPassObj =>new LoginMethodPassword();
        LoginMethodUsername LoginMethodUserObj =>new LoginMethodUsername();
        ProfileMethods profileMethods => new ProfileMethods();
        ProfileAssert pa => new ProfileAssert();
        private IWebElement xpathnew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));


        [Given(@"User is logged in and is currently on Profile Page")]
        public void GivenUserIsLoggedInAndIsCurrentlyOnProfilePage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();

            marsMstrPgObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }

        [When(@"User selects Availability, Hours, Earn Target")]
        public void WhenUserSelectsAvailabilityHoursEarnTarget()
        {
            
            Thread.Sleep(2000);
            profileMethods.profileEditButtonAvailability(0);

            Thread.Sleep(2000);

            profileMethods.profileEditButtonHours(0);

            Thread.Sleep(2000);

            profileMethods.profileEditButtonEarnTarget(0);
        }

        [Then(@"User is able to amed all (.*) fields successfully")]
        public void ThenUserIsAbleToAmedAllFieldsSuccessfully(int p0)
        {
            if (pa.assertNotification().Trim() == "Availability updated")
            {
                Console.WriteLine("Test Successful");
            }
            else
            {

                Console.WriteLine("Test Not Successful and below message displayed");
                Console.WriteLine(pa.assertNotification().Trim());
            }
        }
    }
}
