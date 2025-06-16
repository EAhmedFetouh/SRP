
namespace SRP.SRP
{
    public class UserOperatoinService
    {
        public int Create(string username, string password)
        {
            Console.WriteLine($"Creating user {username}");
            return 1;
        }

        public int Update(string username, string password)
        {
            Console.WriteLine($"Update user {username}");
            return 1;
        }

        public int Delete(string username, string password)
        {
            Console.WriteLine($"Delete user {username}");
            return 1;
        }
    }
}
