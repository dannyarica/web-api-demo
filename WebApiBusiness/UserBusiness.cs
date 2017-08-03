using System.Collections.Generic;

namespace WebApiBusiness
{
    public class UserBusiness
    {

        public Dictionary<string, string> domains = new Dictionary<string, string>() { { "admin", "admin" }, { "user", "public" } };
        public bool IsAuthenticated(string user, string password)
        {
            return (user.Equals("admin") & password.Equals("123456")) || (user.Equals("user") & password.Equals("user"));
        }

        public bool IsAuthorized(string user, string domain)
        {
            return domains[user].Equals(domain);
        }
    }
}