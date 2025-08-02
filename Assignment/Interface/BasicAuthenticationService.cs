using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface
{
    internal class BasicAuthenticationService:IAuthenticationService
    {
        private Dictionary<string, string> users = new Dictionary<string, string>()
    {
        { "admin", "1234" },
        { "user", "abcd" }
    };

        private Dictionary<string, string> roles = new Dictionary<string, string>()
    {
        { "admin", "Admin" },
        { "user", "Viewer" }
    };

        public bool AuthenticateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return roles.ContainsKey(username) && roles[username] == role;
        }
    }
}
