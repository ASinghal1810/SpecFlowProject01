using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SpecFlowProject1.Drivers;

namespace SpecflowProject1.Drivers
{
    public class MarsBroswer : MarsHook
    {
        private IWebDriver driver;

        public MarsBroswer(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string MarsBroswerGetScreenShot()
        {
            Thread.Sleep(200);
            var file = ((ITakesScreenshot)driver).GetScreenshot();
            var img = file.AsBase64EncodedString;

            return img;
        }
    }
}
