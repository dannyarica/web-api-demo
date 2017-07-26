namespace WebApiBusiness
{
    public class UserBusiness
    {
        public bool IsAuthenticated(string user, string password)
        {
            return (user.Equals("admin") & password.Equals("123456"));
        }
    }
}