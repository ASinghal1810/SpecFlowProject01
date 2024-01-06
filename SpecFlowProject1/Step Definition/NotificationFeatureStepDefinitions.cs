using OpenQA.Selenium.Chrome;
using SpecflowProject1.Drivers;
using SpecflowProject1.Pages.MasterPage;
using SpecflowProject1.Pages.MasterPage.Login;
using SpecFlowProject1.Assertions;
using System;
using TechTalk.SpecFlow;

namespace SpecflowProject1.Pages.HomePage.Components.Dashboard
{
    [Binding]
    public class NotificationFeatureStepDefinitions : CommonDriver
    {
        MarsMasterPage MarsMasterPageObj => new MarsMasterPage();
        MarsHomePage MarsHomePageObj => new MarsHomePage();
        LoginMethodPassword LoginMethodPassObj=>new LoginMethodPassword();
        LoginMethodUsername LoginMethodUserObj => new LoginMethodUsername();
        Notification NotificationObj => new Notification();
        NotificationAssert pa => new NotificationAssert();
        //public NotificationFeatureStepDefinitions()
        //{
        //    MarsHomePageObj = new MarsHomePage();
        //    MarsMasterPageObj = new MarsMasterPage();
        //    LoginMethodPassObj = new LoginMethodPassword();
        //    LoginMethodUserObj = new LoginMethodUsername();
        //    NotificationObj = new Notification();
        //}




        [Given(@"I logged on to Portal Successfully")]
        public void GivenILoggedOnToPortalSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            MarsMasterPageObj.MarsMasterPageNavigateToSignInForm();

            MarsMasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }

        [When(@"User Clicks on Dashboard Componenet Button")]
        public void WhenUserClicksOnDashboardComponenetButton()
        {
            MarsHomePageObj.manageDashboardComponentButton();
        }
        //And User Clicks on delete (x) icon
        [When(@"User Clicks on delete \(x\) icon")]
        public void WhenUserClicksOnDeleteXIcon()
        {
            NotificationObj.marsNotificationDelete();
        }

        [Then(@"Notification is deleted succfully")]
        public void ThenNotificationIsDeletedSuccfully()
        {
            throw new PendingStepException();
        }

    }
}
