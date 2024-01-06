
using OpenQA.Selenium;
using SpecflowProject1.Drivers;

namespace SpecflowProject1.Pages.MasterPage
{
    public class MarsMasterPage : CommonDriver
    {
        private static IWebElement MasterPageJoinButton => driver.FindElement(By.XPath("//*[@class='ui green basic button' and 'Join']"));
        private static IWebElement MasterPageSignInButton=> driver.FindElement(By.XPath("//*[@class='item' and 'Sign In']"));
        private static IWebElement MasterPageLoginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private static IWebElement MasterPageFirstName => driver.FindElement(By.Name("firstName"));
        private static IWebElement MasterPageLastName => driver.FindElement(By.Name("lastName"));
        private static IWebElement MasterPageEmail => driver.FindElement(By.Name("email"));
        private static IWebElement MasterPagePassword => driver.FindElement(By.Name("password"));
        private static IWebElement MasterPageConfirmPassword => driver.FindElement(By.Name("confirmPassword"));
        private static IWebElement MasterPageTermsCheckBox => driver.FindElement(By.Name("terms"));
        private static IWebElement MasterPageSubmitButton => driver.FindElement(By.Id("submit-btn"));

        //public MarsMasterPage()
        //{
        //    //MasterPageJoinButton = driver.FindElement(By.XPath("//*[@class='ui green basic button' and 'Join']"));
        //    //MasterPageSignInButton = driver.FindElement(By.XPath("//*[@class='item' and 'Sign In']"));
        //    MasterPageLoginButton = driver.FindElement(By.XPath("//button[@class=\"fluid ui teal button\"]"));
        //    MasterPageFirstName = driver.FindElement(By.Name("firstName"));
        //    MasterPageLastName = driver.FindElement(By.Name("lastName"));
        //    MasterPageEmail = driver.FindElement(By.Name("email"));
        //    MasterPagePassword = driver.FindElement(By.Name("password"));
        //    MasterPageConfirmPassword = driver.FindElement(By.Name("confirmPassword"));
        //    MasterPageTermsCheckBox = driver.FindElement(By.Name("terms"));
        //    MasterPageSubmitButton =driver.FindElement(By.Id("submit-btn"));
        //}


        public void MarsMasterPageNavigateToLandingPage() => driver.Navigate().GoToUrl("http://localhost:5000/");

        public void MarsMasterPageNavigateToJoinForm() => MasterPageJoinButton.Click();

        public void MarsMasterPageNavigateToSignInForm() => MasterPageSignInButton.Click();

        public void MarsMasterPageResisterUserDetails(string fName, string lName, string eMail, string password, string confirmPassword)
        {

            MasterPageFirstName.SendKeys(fName);
            MasterPageLastName.SendKeys(lName);
            MasterPageEmail.SendKeys(eMail);
            MasterPagePassword.SendKeys(password);
            MasterPageConfirmPassword.SendKeys(confirmPassword);
            MasterPageTermsCheckBox.Click();
            MasterPageSubmitButton.Click();

        }

        public void MarsMasterPageLoginUser(string username, string password)
        {
            MasterPageEmail.SendKeys(username);
            MasterPagePassword.SendKeys(password);
            MasterPageLoginButton.Click();

        }
    }
}