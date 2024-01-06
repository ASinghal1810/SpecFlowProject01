using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SpecflowProject1.Pages.MasterPage.Login
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ExpectedResult { get; set; }
    }
}
