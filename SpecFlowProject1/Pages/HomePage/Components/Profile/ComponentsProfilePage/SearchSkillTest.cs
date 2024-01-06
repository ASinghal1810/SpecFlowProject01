//using SpecflowProject1.Driver;
//using Newtonsoft.Json;
//using NUnit.Framework;
//using SpecflowProject1.Pages.MasterPage;
//using SpecflowProject1.Drivers;
//using SpecflowProject1.Pages.MasterPage.Login;
//using SpecflowProject1.Pages.HomePage.Components.Profile;
//using OpenQA.Selenium;
//using SpecflowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification;
//using SpecflowProject1.Pages.HomePage.Search_Skills;

//namespace SpecflowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage
//{
//    [TestFixture]
//    [Parallelizable]

//    public class SearchSkillTest : CommonDriver
//    {

//        MarsMasterPage marsMstrPgObj => new MarsMasterPage();
//        LoginMethods lMObj => new LoginMethods();
//        SkillSearch skillObj => new SkillSearch();

//        [Test, Order(1), Description("Search Skills --> by All Categories, Sub Categories")]
//        public void TestCase()
//        {
//            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\New folder (2)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
//            Users users = JsonConvert.DeserializeObject<Users>(dataJson);

//            User user = users.users.ElementAt(0);
//            Thread.Sleep(200);
//            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();
//            Thread.Sleep(200);
//            marsMstrPgObj.MarsMasterPageLoginUser(lMObj.userUsername(0), lMObj.userPassword(0));
//            Thread.Sleep(2000);
//            skillObj.skillToSearch("sssssssssss", "Programming & Tech", "Data Analysis & Reports");
//        }

//    }
//}