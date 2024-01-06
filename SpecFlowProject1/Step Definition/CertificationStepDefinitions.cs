using OpenQA.Selenium.Chrome;
using SpecflowProject1.Pages.HomePage.Components.Dashboard;
using SpecflowProject1.Pages.HomePage;
using SpecflowProject1.Pages.MasterPage.Login;
using SpecflowProject1.Pages.MasterPage;
using System;
using TechTalk.SpecFlow;
using SpecflowProject1.Drivers;
using SpecflowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification;
using NUnit.Framework;
using System.Security.Policy;
using System.Drawing.Text;
using OpenQA.Selenium;
using SpecFlowProject1.Assertions;

namespace SpecFlowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification
{
    [Binding]
    public class CertificationStepDefinitions : CommonDriver
    {
        MarsMasterPage MarsMasterPageObj => new MarsMasterPage();
        LoginMethodPassword LoginMethodPassObj => new LoginMethodPassword();
        LoginMethodUsername LoginMethodUserObj => new LoginMethodUsername();

        MarsProfilePageCertificationsMethods certObj = new MarsProfilePageCertificationsMethods();

        CertificationAssert pa => new CertificationAssert();


        [Given(@"I logged into portal successfully to add certificate")]
        public void GivenILoggedIntoPortalSuccessfullyToAddCertificate()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            MarsMasterPageObj.MarsMasterPageNavigateToSignInForm();

            MarsMasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }

        [When(@"User enters a Certificate '([^']*)' , Institution '([^']*)' & Year '([^']*)'")]
        public void WhenUserEntersACertificateInstitutionYear(string p0, string institution, string iSTQB)
        {
            certObj.marsProfilePageCertificationsAddClick();


        }
        [When(@"Clicks on add button")]
        public void WhenClicksOnAddButton()
        {
            certObj.marsProfilePageCertificationsAdd();
        }



        [Then(@"'([^']*)' is added successfully")]
        public void ThenIsAddedSuccessfully(string p0)
        {
            string newcert = p0.ToString() + " has been added to your certification";
            if (pa.assertNotification().Trim() == newcert.ToString())
            {
                Console.WriteLine("Cert Added Successfully");
            }
            else
            {
                Console.WriteLine("Cert Addition UnSuccessfull");
            }
        }
        [Given(@"I logged into portal successfully to edit certification")]
        public void GivenILoggedIntoPortalSuccessfullyToEditCertification()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            MarsMasterPageObj.MarsMasterPageNavigateToSignInForm();

            MarsMasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }

        [When(@"Clicks on update button")]
        public void WhenClicksOnUpdateButton()
        {
            certObj.marsProfilePageCertificationsEdit();
        }

        [Then(@"'([^']*)' is edited successfull")]
        public void ThenIsEditedSuccessfull(string certificate, Table table)
        {
            string newcert = certificate.ToString() + " has been updated to your certification";
            if (pa.assertNotification().Trim() == newcert.ToString())
            {
                Console.WriteLine("Cert Edited Successfully");
            }
            else
            {
                Console.WriteLine("Cert updation UnSuccessfull");
            }
        }




        [Given(@"I logged into portal successfully to delete certification")]
        public void GivenILoggedIntoPortalSuccessfullyToDeleteCertification()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            MarsMasterPageObj.MarsMasterPageNavigateToSignInForm();

            MarsMasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));
        }
        [When(@"Clicks on x icon")]
        public void WhenClicksOnXIcon()
        {
            
            certObj.marsProfilePageCertificationsDelete();
        }

        [Then(@"Certification is deleted successfully")]
        public void ThenCertificationIsDeletedSuccessfully()
        {
             IWebElement deletecert = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]"));
            string CertDeleted = deletecert.ToString() + " has been deleted from your certification";
        if (pa.assertNotification().Trim() == CertDeleted.ToString())
        {
             Console.WriteLine("Cert Edited Successfully");
        }
            else
            {
                Console.WriteLine("Cert updation UnSuccessfull");
            }
        }
    }
}
