
namespace SRP
{
    public class UserEndpoint
    {
        private readonly UserManagerService _userManager;

        public UserEndpoint(UserManagerService userManager)
        {
            _userManager = userManager;
        }

        public void RegisterUser(string username, string password, string email)
        {
            int userId = _userManager.Create(username,password);
            _userManager.SendWelcomeEmail(email);
            _userManager.Log("Registered");
        }

        public bool AuthicateUser(string username, string password)
        {
            _userManager.ValidateUser(username, password);
            _userManager.SendWelcomeEmail("Authenticated");
            _userManager.Log("Authentecated");
            return true;
        }
    }
}
