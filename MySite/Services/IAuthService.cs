using MySite.Models;
using ErrorEventArgs = MySite.Models.ErrorEventArgs;

namespace MySite.Services;

public interface IAuthService
{
    public delegate void RegistrationHandler(object sender, RegistrationEventArgs e);
    public delegate void LoginHandler(object sender, LoginEventArgs e);
    public delegate void ErrorHandler(object sender, ErrorEventArgs e);

    public event RegistrationHandler OnTryRegister;
    public event LoginHandler OnTryLogin;
    public event EventHandler OnLoginSuccess;
    public event EventHandler OnRegistrationSuccess;
    public event ErrorHandler OnLoginFailed;
    public event ErrorHandler OnRegistrationFailed;
    
    void RegisterVisitor(RegistrationEventArgs registrationEventArgs);
    void CheckVisitorLoginData(LoginEventArgs registrationEventArgs);
}