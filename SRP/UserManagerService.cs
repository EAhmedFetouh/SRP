
/* Single Responsibility:-
A class should have only one reason to change." The Single Responsibility Principle states that
a class should only have one responsibility, meaning it should only have one job or function.In other words,
each class should encapsulate one part of the functionality provided by the software, and that functionality 
should be entirely encapsulated by the class.
*/



namespace SRP;

public class UserManagerService
{
    private readonly EmailService _emailService;

    public UserManagerService()
    {
        _emailService = new EmailService();
        if (!_emailService.Initialize())
        {
            throw new Exception("Cannot initialize Email Service!");
        }
    }
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

    public bool ValidateUser(string username, string password)
    {
        Console.WriteLine($"Validating password for {username}");
        return true;
    }

    public void SendWelcomeEmail(string email)
    {
        Console.WriteLine($"Sending welcome email to {email}");
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }




    public class EmailService
    {
        public bool Initialize()
        {
            return false;
        }
    }
}



  


