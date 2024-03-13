using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject1.Components.LoginComponent;
using SpecFlowProject1.Components.NotificationComponent;

namespace SpecFlowProject1.Step_Definition
{
    [Binding]
    public class MarsNotificationFeatureStepDefinitions
    {
        MarsLogin login = new MarsLogin();
        MarsNotification notification = new MarsNotification();

        [Given(@"I logged into the Mars portal using valid credentials")]
        public void GivenILoggedIntoTheMarsPortalUsingValidCredentials()
        {
            login.clickSignInButton();
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string signinEmailAddress = jsonData.emailAddress;
            string signinPassword = jsonData.password;

            login.loginWithCredentails(signinEmailAddress, signinPassword);
        }

        [When(@"I click the notification dropdown list and select the see all option")]
        public void WhenIClickTheNotificationDropdownListAndSelectTheSeeAllOption()
        {
            notification.goToNotificationPage();
        }

        [Then(@"I should see all my notification and mark first notification as read")]
        public void ThenIShouldSeeAllMyNotificationAndMarkFirstNotificationAsRead()
        {
            notification.markFirstNotificationAsRead("Mark the first notification!");
        }

        [Then(@"I should see the successfull message pop-up to the portal")]
        public void ThenIShouldSeeTheSuccessfullMessagePop_UpToThePortal()
        {
            notification.assertTheSuccessfulMessage("The first notification has been marked!");
        }
    }
}