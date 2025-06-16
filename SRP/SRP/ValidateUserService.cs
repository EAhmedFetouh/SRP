
namespace SRP.SRP;

public class ValidateUserService
{
    public bool ValidateUser(string username, string password)
    {
        Console.WriteLine($"Validating password for {username}");
        return true;
    }
}
