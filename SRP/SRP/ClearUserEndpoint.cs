

namespace SRP.SRP;

public class ClearUserEndpoint
{
    private readonly UserOperatoinService _userOperatoinService;
    private readonly EmailService _emailService;
    private readonly LogService _logService;
    private readonly ValidateUserService _validateUserService;

    public ClearUserEndpoint(UserOperatoinService userOperatoinService, ValidateUserService validateUserService,
        LogService logService, EmailService emailService)
    {
        _userOperatoinService = userOperatoinService;
        _validateUserService = validateUserService;
        _logService = logService;
        _emailService = emailService;
    }

    public void RegisterUser(string username, string password, string email)
    {
        int userId = _userOperatoinService.Create(username, password);
        _emailService.SendWelcomeEmail(email);
        _logService.Log("Registered");
    }

    public bool AuthicateUser(string username, string password)
    {
        _validateUserService.ValidateUser(username, password);
        _emailService.SendWelcomeEmail("Authenticated");
        _logService.Log("Authentecated");
        return true;
    }
}
