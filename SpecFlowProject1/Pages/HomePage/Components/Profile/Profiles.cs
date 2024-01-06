using SpecflowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SpecflowProject1.Pages.HomePage.Components.Profile
{
    public class Profiles
    {
        public List<Profile> profileAvailability { get; set; }
        public List<Profile> profileHours { get; set; }
        public List<Profile> profileEarnTarget { get; set; }
    }
}
