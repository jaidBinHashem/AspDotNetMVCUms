using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemApp.DAL.Model
{
    public class Login
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string acctype { get; set; }
    }
}