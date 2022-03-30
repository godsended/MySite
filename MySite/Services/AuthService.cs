using MySite.Data;
using MySite.Models;

namespace MySite.Services;

public class AuthService : IAuthService
{
    public event IAuthService.RegistrationHandler? OnTryRegister;
    public event IAuthService.LoginHandler? OnTryLogin;
    public event EventHandler? OnLoginSuccess;
    public event EventHandler? OnRegistrationSuccess;
    public event IAuthService.ErrorHandler? OnLoginFailed;
    public event IAuthService.ErrorHandler? OnRegistrationFailed;

    private UsersDbContext usersDbContext;

    public AuthService(UsersDbContext usersDbContext)
    {
        this.usersDbContext = usersDbContext;
        OnTryRegister += ProcessRegistration;
        OnTryLogin += ProcessLogin;
    }

    public void RegisterVisitor(RegistrationEventArgs e)
    {
        
        OnTryRegister.Invoke(this, e);
    }

    public void CheckVisitorLoginData(LoginEventArgs e)
    {
        
    }

    private async void ProcessRegistration(object sender, RegistrationEventArgs e)
    {
        User user = new User();
        user.Name = e.Name;
        user.Company = e.Company;
        user.Mail = e.Mail;
        user.Password = e.Password;

        await usersDbContext.Users.AddAsync(user);
        usersDbContext.SaveChangesAsync();
    }
    
    private void ProcessLogin(object sender, LoginEventArgs e)
    {
        
    }
}