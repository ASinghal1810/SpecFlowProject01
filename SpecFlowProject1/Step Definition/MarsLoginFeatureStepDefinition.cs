using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SpecFlowProject1.Components.LoginComponent;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.Step_Definition
{
    [Binding]
    public class MarsLoginFeatureStepDefinitions : MarsHook
    {

        MarsLogin login = new MarsLogin();

        [Given(@"I click the Sign In button")]
        public void ThenIClickTheSignInButton()
        {
            login.clickSignInButton();
        }

        [When(@"I enter valid emailAddress and password")]
        public void WhenIEnterValidEmailAddressAndPassword()
        {
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string signinEmailAddress = jsonData.emailAddress;
            string signinPassword = jsonData.password;

            login.loginWithCredentails(signinEmailAddress, signinPassword);
        }

        [Then(@"I should be able to see my account UserName in the profile page")]
        public void ThenIShouldBeAbleToSeeMyAccountUserNameInTheProfilePage()
        {
            string expecedAccountName = login.assertAccountName();
            Assert.That(expecedAccountName == "Eddie He", "Actual account name and expected account name do not match!");
        }
    }
}
