using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Q_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
      

        public bool AuthenticateUser(string username, string password)
        {
           if(username=="Marina" && password == "1223") { return true; }
           return false;
        }

      

        public bool AuthorizeUser(string username, string role)
        {
            return (username == "Marina" && role == "Developer") ? true : false;
            
        }
    }
}
