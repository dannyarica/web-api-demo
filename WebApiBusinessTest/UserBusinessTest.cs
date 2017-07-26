using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBusiness;

namespace WebApiBusinessTest
{
    [TestFixture]
    public class UserBusinessTest
    {
        [TestCase]
        public void Test_ValidateUser_Authenticated()
        {
            var userBusiness = new UserBusiness();

            var isAuthenticated = userBusiness.IsAuthenticated("admin", "123456");

            Assert.IsTrue(isAuthenticated);
        }

        [TestCase]
        public void Test_ValidateUser_NoAuthenticated()
        {
            var userBusiness = new UserBusiness();

            var isAuthenticated = userBusiness.IsAuthenticated("", "");

            Assert.IsFalse(isAuthenticated);
        }
    }
}
