using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SpecFlowProject1.Components.LoginComponent;
using SpecFlowProject1.Components.ProfileComponent;
using SpecFlowProject1.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Step_Definition
{
    [Binding]
    public class MarsProfileFeatureStepDefinitions
    {
        MarsLogin login = new MarsLogin();
        MarsProfilePage profilePage = new MarsProfilePage();
        MarsProfileDescription profileDescription = new MarsProfileDescription();
        MarsProfileLanguages profileLanguages = new MarsProfileLanguages();

        [Given(@"I logged into the Mars portal")]
        public void GivenILoggedIntoTheMarsPortal()
        {
            login.clickSignInButton();
            var jsonData = ScenarioContext.Current.Get<UserData>("UserData");

            string signinEmailAddress = jsonData.emailAddress;
            string signinPassword = jsonData.password;

            login.loginWithCredentails(signinEmailAddress, signinPassword);
        }

        [When(@"I see my account name on the user profile page")]
        public void WhenISeeMyAccountNameOnTheUserProfilePage()
        {
            string expecedAccountName = login.assertAccountName();
            Assert.That(expecedAccountName == "Eddie He", "Actual account name and expected account name do not match!");
        }

        [When(@"I add my user details")]
        public void WhenIAddMyUserDetails()
        {
            profilePage.addProfileUserDetail("User details has been added!!");
        }

        [Then(@"I am add my first language including '([^']*)' name and language level")]
        public void ThenIAmAddMyFirstLanguageIncludingNameAndLanguageLevel(string language1)
        {
            profileLanguages.marsAddProfileLanguage1("Language1 has been added!", language1);
        }

        [Then(@"Then I am add my second language including '([^']*)' name and language level")]
        public void ThenThenIAmAddMySecondLanguageIncludingNameAndLanguageLevel(string language2)
        {
            profileLanguages.marsAddProfileLanguage2("Language2 has been added!", language2);
        }

        [Then(@"I am add my '([^']*)' into the description text area")]
        public void ThenIAmAddMyIntoTheDescriptionTextArea(string description)
        {
            profileDescription.marsProfileDecriptionEdit(description);
        }


        [Then(@"I can edit my profile user details")]
        public void ThenICanEditMyProfileUserDetails()
        {
            profilePage.editProfileUserDetail("User details has been edit!!");
        }

        [Then(@"I am edit my first language including '([^']*)' name and language level")]
        public void ThenIAmEditMyFirstLanguageIncludingNameAndLanguageLevel(string language3)
        {
            profileLanguages.marsEditProfileLanguage1("Language1 has been changed!!", language3);
        }

        [Then(@"I am edit my second language including '([^']*)' name and language level")]
        public void ThenIAmEditMySecondLanguageIncludingNameAndLanguageLevel(string language4)
        {
            profileLanguages.marsEditProfileLanguage2("Language2 has been changed!!", language4);
        }

        [Then(@"I edit my '([^']*)' into the description text area")]
        public void ThenIEditMyIntoTheDescriptionTextArea(string description)
        {
            profileDescription.marsProfileDecriptionEdit(description);
        }


    }
}