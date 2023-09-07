using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCplus.Models
{
    public class UserProfile
    {
        public string Username { get; set; }
        public string UserType { get; set; }
        // Other properties you might need

        public UserProfile(string username, string userType)
        {
            Username = username;
            UserType = userType;
        }
    }
}
