using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecflowProject1.Drivers;
using SpecflowProject1.Pages.HomePage;
using SpecflowProject1.Pages.HomePage.Components.ManageListings;
using SpecflowProject1.Pages.HomePage.Components.Profile.ComponentsProfilePage.Certification;
using SpecflowProject1.Pages.HomePage.Components.Profile;
using SpecflowProject1.Pages.MasterPage;
using System;
using TechTalk.SpecFlow;
using SpecflowProject1.Pages.MasterPage.Login;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Pages.HomePage.Components.ManageListings
{
    [Binding]
    public class MalanageListingEditStepDefinitions : CommonDriver
    {
        MarsMasterPage marsMstrPgObj => new MarsMasterPage();

        MarsHomePage mhpg = new MarsHomePage();


        LoginMethodPassword LoginMethodPassObj => new LoginMethodPassword();
        LoginMethodUsername LoginMethodUserObj => new LoginMethodUsername();


        MarsProfilePageCertificationsMethods certObj = new MarsProfilePageCertificationsMethods();
        private IWebElement xpathnew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));

        ProfileMethods profileMethods => new ProfileMethods();

      
        IfBlock ifBlockObj => new IfBlock();

        private IWebElement editListing => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        private IWebElement titleTextBox => driver.FindElement(By.Name("title"));
        private IWebElement descTestBox => driver.FindElement(By.Name("description"));
        private IWebElement categoryDropDown => driver.FindElement(By.Name("categoryId"));
        private IWebElement subCategoryDropDown => driver.FindElement(By.Name("subcategoryId"));
        private IWebElement tags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement serviceTypeHourlyRB => driver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement serviceTypeOneOffRB => driver.FindElement(By.XPath("//*[@name=\"serviceType\" and @tabindex=\"0\" and @value=\"1\"]"));
        private IWebElement locationTypeOnSiteRB => driver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"0\"]"));
        private IWebElement locationTypeOnlineRB => driver.FindElement(By.XPath("//*[@name=\"locationType\" and @tabindex=\"0\" and @value=\"1\"]"));
        private IWebElement startDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        private IWebElement endDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        private IWebElement sunday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"0\"]"));
        private IWebElement sundayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"0\"]"));
        private IWebElement sundayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"0\"]"));
        private IWebElement monday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"1\"]"));
        private IWebElement mondayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"1\"]"));
        private IWebElement mondayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"1\"]"));
        private IWebElement tuesday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"2\"]"));
        private IWebElement tuesdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"2\"]"));
        private IWebElement tuesdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"2\"]"));
        private IWebElement wednesday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"3\"]"));
        private IWebElement wednesdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"3\"]"));
        private IWebElement wednesdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"3\"]"));
        private IWebElement thursday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"4\"]"));
        private IWebElement thursdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"4\"]"));
        private IWebElement thursdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"4\"]"));
        private IWebElement friday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"5\"]"));
        private IWebElement fridayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"5\"]"));
        private IWebElement fridayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"5\"]"));
        private IWebElement saturday => driver.FindElement(By.XPath("//input[@name=\"Available\" and @index=\"6\"]"));
        private IWebElement saturdayST => driver.FindElement(By.XPath("//input[@name=\"StartTime\" and @index=\"6\"]"));
        private IWebElement saturdayET => driver.FindElement(By.XPath("//input[@name=\"EndTime\" and @index=\"6\"]"));
        private IWebElement sTradeTypeRB => driver.FindElement(By.XPath("//input[@name=\"skillTrades\" and @tabindex=\"0\" and @value=\"false\"]"));
        private IWebElement credit => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
        private IWebElement sExch => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement workSamples => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement sSIsActive => driver.FindElement(By.XPath("//*[@name=\"isActive\" and @tabindex=\"0\" and @value=\"true\"]"));
        private IWebElement sSIsHidden => driver.FindElement(By.XPath("//*[@name=\"isActive\" and @tabindex=\"0\" and @value=\"false\"]"));
        private IWebElement saveB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private IWebElement cancelB => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]"));
        private IWebElement titleText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private IWebElement descriptionText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
        private IWebElement categoryText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
        private IWebElement serviceTypeText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement tagRemoval => driver.FindElement(By.XPath("//*[@class=\"ReactTags__tag\"]/a"));
        private IWebElement acceptOrDecline => driver.FindElement(By.XPath("//*[@class=\"ui icon positive right labeled button\"]"));
        AssertNotify pa => new AssertNotify();
        [Given(@"User is logged in successfully")]
        public void GivenUserIsLoggedInSuccessfully()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            marsMstrPgObj.MarsMasterPageNavigateToSignInForm();

            marsMstrPgObj.MarsMasterPageLoginUser(LoginMethodUserObj.userUsername(0), LoginMethodPassObj.userPassword(0));

            Thread.Sleep(2000);
            mhpg.manageListingComponentButton();
            
        }

        [When(@"User clicks on edit listing")]
        public void WhenUserClicksOnEditListing()
        {
            MarsWait.WaitToBeClickable("XPath", 20, "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i");
            editListing.Click();
        }

        [When(@"Inputs required information")]
        public void WhenInputsRequiredInformation()
        {
            
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\EditListing.json");
            ManageListingsKey manageList = JsonConvert.DeserializeObject<ManageListingsKey>(dataJson);
            ManageListing profile = manageList.manageList.ElementAt(0);


            //Title
            MarsWait.WaitToBeClickable("Name", 10, "title");
            titleTextBox.Clear();
            titleTextBox.SendKeys(profile.Title);
            Thread.Sleep(20);

            //Description
            MarsWait.WaitToBeClickable("Name", 10, "description");
            descTestBox.Clear();
            Thread.Sleep(20);
            descTestBox.SendKeys(profile.Description);

            Thread.Sleep(20);

            //Category
            SelectElement categorySelect = new SelectElement(categoryDropDown);
            categorySelect.SelectByValue(profile.Category);
            Thread.Sleep(20);

            //Sub Category
            MarsWait.WaitToBeClickable("Name", 10, "categoryId");
            SelectElement subCategorySelect = new SelectElement(subCategoryDropDown);
            subCategorySelect.SelectByValue(profile.SubCategory);
            Thread.Sleep(20);

            //Tags
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input");
            tagRemoval.Click();
            tags.SendKeys(profile.Tags + "\n");
            Thread.Sleep(20);

            //Service Type Radio Button
            if (profile.ServiceType == "Hourly")
            {
                serviceTypeHourlyRB.Click();
            }
            else
            {
                serviceTypeOneOffRB.Click();
            }
            Thread.Sleep(200);

            //Location Type
            if (profile.LocationType == "Online")
            {
                locationTypeOnSiteRB.Click();
            }
            else
            {
                locationTypeOnlineRB.Click();
            }
            Thread.Sleep(20);

            //Start Date
            startDate.SendKeys(profile.StartDate);

            //End Date
            if (profile.EndDate != null)
            {
                endDate.SendKeys(profile.EndDate);
            }

            ////Sundat to Saturday Check Boxes
            //ifBlockObj.DaysIfBlock(sunday, sundayST, sundayET, profile.Sun, profile.SunFrom, profile.SunTo);
            //ifBlockObj.DaysIfBlock(monday, mondayST, mondayET, profile.Mon ,profile.MonFrom ,profile.MonTo);
            //ifBlockObj.DaysIfBlock(tuesday, tuesdayST, tuesdayET, profile.Tue, profile.TueFrom, profile.TueTo);
            //ifBlockObj.DaysIfBlock(wednesday, wednesdayST, wednesdayET, profile.Wed, profile.WedFrom, profile.WedTo);
            //ifBlockObj.DaysIfBlock(thursday, thursdayST, thursdayET, profile.Thur, profile.ThurFrom, profile.ThurTo);
            //ifBlockObj.DaysIfBlock(friday, fridayST, fridayET, profile.Fri, profile.FriFrom, profile.FriTo);
            //ifBlockObj.DaysIfBlock(saturday, saturdayST, saturdayET, profile.Sat, profile.SatFrom, profile.SatTo);

            Thread.Sleep(200);
            //Wait.WaitToBeClickable(CommonDriver, "XPath", 5, "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]");
            //sTradeTypeRB.Click();

            //Credit Or Skill-Exchange
            if (profile.SkillTrade == "Skill-Exchange")
            {
                sExch.Click();
                sExch.SendKeys(profile.SkillExchange);
                sExch.SendKeys("\n");
            }
            else
            {
                credit.Click();
                credit.SendKeys(profile.Credit);
            }

            Thread.Sleep(30);
            //Work Samples
            // Identify the Work Samples and click the plus button to upload photo
            //  Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i");
            workSamples.Click();
            Thread.Sleep(2000);
            // AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(500);
            //autoIt.WinActivate("Open");
            Thread.Sleep(2000);
            //autoIt.Send(@"C:\Users\ankur\Desktop\project_Mars\download.png");
            Thread.Sleep(2000);
            //autoIt.Send("{ENTER}");
            Thread.Sleep(2000);



            //Active/Deactive
            if (profile.Active == "Active")
            {
                sSIsActive.Click();
            }
            else
            {
                sSIsHidden.Click();
            }

            //SaveButton
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            saveB.Click();
            
        }

        [Then(@"Listed is updated successfully")]
        public void ThenListedIsUpdatedSuccessfully()
        {
            //if (pa.assertNotification().Trim() == "Service Listing Updated successfully")
            //{
            //    Console.WriteLine("Test Successful");
            //}
            //else
            //{

            //    Console.WriteLine("Test Not Successful and below message displayed");
            //    Console.WriteLine(pa.assertNotification().Trim());
            //}
        }
    }
}
