using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityManagementSystemApp.DAL.Model;

namespace UniversityManagementSystemApp.DAL.Gateway
{
    public class LoginGateway : Gateway
    {
        public Login GetUser(string username, string password)
        {
            Login user = new Login();
            Query = "SELECT  * FROM Login WHERE username = '" + username + "' and Password ='" + password + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();

            if (Reader.Read())
            {
                user.id = (int) Reader["id"];
                user.username = Reader["username"].ToString();
                user.email = Reader["email"].ToString();
                user.password = Reader["password"].ToString();
                user.acctype = Reader["acctype"].ToString();
                
            }
            return user;
        }
    }
}