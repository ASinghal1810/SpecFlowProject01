using SpecflowProject1.Drivers;
using Newtonsoft.Json;
using OpenQA.Selenium;

namespace SpecflowProject1.Pages.HomePage.Search_Skills
{
    public class SkillSearch : CommonDriver
    {
        private IWebElement marsLogo => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
        private IWebElement programmingAndTech => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/section[1]/div/div[2]/div/div[2]/div[2]/a/img"));
        private IWebElement dataAnalysisAndReports => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[10]"));
        private IWebElement skillSelect => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/div[1]/a[2]/p"));

        private IWebElement skillFound => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));

        public void skillToSearch(string skill, string category, string subCategory)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\New folder (2)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\SearchSkill.json");
            SearchSkills searchskills = JsonConvert.DeserializeObject<SearchSkills>(dataJson);
            SearchSkill sSkill = searchskills.searchskills.ElementAt(0);
            marsLogo.Click();
            if (sSkill.Category == category)
            {
                MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"home\"]/div/section[1]/div/div[2]/div/div[2]/div[2]/a/img");
                programmingAndTech.Click();
                if (sSkill.SubCategory == subCategory)
                {
                    MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[10]");
                    dataAnalysisAndReports.Click();
                    MarsWait.WaitToBeClickable("XPath", 10, "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/div[1]/a[2]/p");
                    skillSelect.Click();
                    if (sSkill.Skill == skillFound.Text.Trim())
                    {

                        Console.WriteLine("Skill Found");
                    }
                    else
                    {
                        Console.WriteLine("Skill Not Found");
                    }
                }
            }

        }
    }
}
