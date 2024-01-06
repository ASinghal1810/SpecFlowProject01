
using TechTalk.SpecFlow;
using SpecflowProject1.Drivers;
using OpenQA.Selenium.Chrome;
using Newtonsoft.Json;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace SpecflowProject1.Pages.MasterPage.Login
{

    [Binding]
    public class LoginStepDefinitions : CommonDriver
    {

        MarsMasterPage MasterPageObj;
        LoginMethodPassword LoginMethodPassObj;
        LoginMethodUsername LoginMethodUserObj;
        //LoginAssertion LoginAssertObj;
        public LoginStepDefinitions()
        {
            MasterPageObj = new MarsMasterPage();
            LoginMethodPassObj = new LoginMethodPassword();
            LoginMethodUserObj = new LoginMethodUsername();
            //LoginAssertObj = new LoginAssertion();

        }

        [Given(@"I logged into portal successfully")]
        public void GivenILoggedIntoPortalSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [When(@"I click on Sign In Button")]
        public void WhenIClickOnSignInButton()
        {
            MasterPageObj.MarsMasterPageNavigateToSignInForm();
        }

        [When(@"Type in Valid Credentials for Case '(.*)'")]
        public void WhenTypeInValidCredentialsForCase(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);
            Console.WriteLine(LoginMethodUserObj.userUsername(i));
            Console.WriteLine(LoginMethodPassObj.userPassword(i));
            MasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(i), LoginMethodPassObj.userPassword(i));
        }


        [Then(@"User is logged in Successfully")]
        public void ThenUserIsLoggedInSuccessfully()
        {
            Console.WriteLine(0 + "Pass");
        }
        [When(@"Type in InValid Credentials for Case '(.*)'")]
        public void WhenTypeInInValidCredentialsForCase(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);
            Console.WriteLine(LoginMethodUserObj.userUsername(i));
            Console.WriteLine(LoginMethodPassObj.userPassword(i));
            MasterPageObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(i), LoginMethodPassObj.userPassword(i));
        }

        [Then(@"Unsuccessful Login")]
        public void ThenUnsuccessfulLogin()
        {
            Console.WriteLine(0 + "Fail");
        }
    }
}

    
