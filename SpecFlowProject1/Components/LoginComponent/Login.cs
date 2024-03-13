using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecflowProject1.Drivers;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.Components.LoginComponent
{
    public class MarsLogin : MarsHook
    {
        // Login Action Element
        private IWebElement signInButton => marsDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement loginEmailaddress => marsDriver.FindElement(By.Name("email"));
        private IWebElement loginPassword => marsDriver.FindElement(By.Name("password"));
        private IWebElement rememberMe => marsDriver.FindElement(By.Name("rememberDetails"));
        private IWebElement loginButton => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement actualAccountName => marsDriver.FindElement(By.XPath("//div[contains(text(), \"Eddie He\")]"));
        private IWebElement errorEmailMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div"));
        private IWebElement errorPasswordMessage => marsDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/div"));

        public void clickSignInButton()
        {
            signInButton.Click();
        }

        public void loginWithCredentails(string emailAddress, string password)
        {
            loginEmailaddress.SendKeys(emailAddress);
            loginPassword.SendKeys(password);
            rememberMe.Click();
            loginButton.Click();
        }

        public string assertAccountName()
        {
            MarsWait.MarsWaitToBeVisible("XPath", 5, "//div[contains(text(), \"Eddie He\")]");
            return actualAccountName.Text;
        }


        public string emailErrorMessage()
        {
            MarsWait.MarsWaitToBeVisible("XPath", 5, "/html/body/div[2]/div/div/div[1]/div/div[1]/div");
            return errorEmailMessage.Text;

        }
        public string passwordErrorMessage()
        {
            MarsWait.MarsWaitToBeVisible("XPath", 5, "/html/body/div[2]/div/div/div[1]/div/div[2]/div");
            return errorPasswordMessage.Text;
        }
    }
}
