using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HCplus.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }


        public User(string username = null, string password = null, string userType = null)
        {
            Username = username;
            Password = password;
            UserType = userType;
        }



        public void AddUser(DbAccess.DbConnection con)
        {
            string tableName = "tbl_users";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
        {
            { "user_type", UserType },
            { "username", Username },
            { "password", Password },
        };

            con.ExecuteInsertQuery(tableName, columnsAndValues);
        }

        
    }
}
