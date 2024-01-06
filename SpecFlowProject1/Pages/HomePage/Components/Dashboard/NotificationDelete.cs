////using SpecflowProject1.Driver;
////using Newtonsoft.Json;
////using NUnit.Framework;
////using SpecflowProject1.Pages.MasterPage;
////using SpecflowProject1.Drivers;
////using SpecflowProject1.Pages.MasterPage.Login;
////using SpecflowProject1.Pages.HomePage.Components.Profile;
//using OpenQA.Selenium;
//using SpecflowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification;
//using SpecflowProject1.Pages.HomePage;
//using SpecflowProject1.Pages.HomePage.Components.ManageListings;
//using System.Runtime.ConstrainedExecution;

//namespace SpecflowProject1.Pages.HomePage.Components.Dashboard
//{
//    [TestFixture]
//    [Parallelizable]

//    public class NotificationDelete : CommonDriver
//    {

//        MarsMasterPage marsMstrPgObj => new MarsMasterPage();

//        MarsHomePage mhpg => new MarsHomePage();

//        Notification notify => new Notification();
//        LoginMethods lMObj => new LoginMethods();




//            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
//            Thread.Sleep(200);
//            marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
//            Thread.Sleep(2000);
//            mhpg.manageDashboardComponentButton();
//            notify.marsNotificationDelete();


//        }

//    }
//}

