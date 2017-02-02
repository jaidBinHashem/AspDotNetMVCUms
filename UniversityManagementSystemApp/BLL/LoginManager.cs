using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystemApp.DAL.Gateway;
using UniversityManagementSystemApp.DAL.Model;

namespace UniversityManagementSystemApp.BLL
{
    public class LoginManager
    {
        public Login GetUser(string username, string password)
        {
            LoginGateway user = new LoginGateway();
            Login userInfo = new Login();
            userInfo = user.GetUser(username,password);
            return userInfo;
        }
    }
}