using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowProject1.Drivers;
using SpecflowProject1.Pages.HomePage.Search_Skills;
using SpecflowProject1.Pages.MasterPage;
using SpecflowProject1.Pages.MasterPage.Login;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage
{
    [Binding]
    public class SearchSkillFeatureStepDefinitions : CommonDriver
    {
        MarsMasterPage marsMstrPgObj => new MarsMasterPage();
        LoginMethodPassword LoginMethodPassObj => new LoginMethodPassword();
        LoginMethodUsername LoginMethodUserObj => new LoginMethodUsername();
        private IWebElement marsLogo => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
        private IWebElement programmingAndTech => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[7]"));
        private IWebElement dataAnalysisAndReports => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[10]"));
        private IWebElement skillSelect => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/a/img"));
        private IWebElement skillSearch => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[2]/input"));
        private IWebElement skillFound => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]"));
        private IWebElement skillSearchClick => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[3]/div/button"));
        
        [Given(@"User is logged in")]
        public void GivenUserIsLoggedIn()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();

            marsMstrPgObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }
        [When(@"User clicks on mars logo")]
        public void WhenUserClicksOnMarsLogo()
        {
            MarsWait.WaitToBeClickable("XPath", 20, "//*[@id=\"account-profile-section\"]/div/div[1]/a");
            marsLogo.Click();
        }

        [When(@"User imputs'([^']*)', '([^']*)', & '([^']*)'")]
        public void WhenUserImputs(string p0, string p1, string p2)
        {
            Thread.Sleep(1000);
            skillSearchClick.Click();
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[7]");
            programmingAndTech.Click();
               
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[10]");
            dataAnalysisAndReports.Click();

            //MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/a/img");
            //skillSelect.Click();
            MarsWait.WaitToBeClickable("XPath", 20, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[2]/input");
            skillSearch.Click();
            skillSearch.SendKeys(p0.ToString());
            skillSearch.SendKeys(Keys.Enter);
            MarsWait.WaitToBeVisible("XPath", 20, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/a/img");
            skillSelect.Click();

        }

        [Then(@"User is able to find '([^']*)' successfully")]
        private void ThenUserIsAbleToFindSuccessfully(string p0)
        {
            if (p0.ToString() == skillFound.Text.Trim())
            {

                Console.WriteLine("Skill Found");
            }
            else
            {
                Console.WriteLine("Skill Not Found");
            }
        }
    }
}
