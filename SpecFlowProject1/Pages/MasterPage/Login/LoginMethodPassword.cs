using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpecflowProject1.Pages.MasterPage.Login
{
    public class LoginMethodPassword
    {
        
        public string userPassword(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\source\repos\SpecFlowProject1\SpecFlowProject1\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);

            return user.Password;
        }
    }
}
