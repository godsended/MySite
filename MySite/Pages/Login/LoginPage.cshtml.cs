using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;
using MySite.Services;

namespace MySite.Pages.Login;

public class LoginPageModel : PageModel
{
    private IAuthService authService;
    private VisitorsDbContext visitorsDbContext;
    private UsersDbContext usersDbContext;
    
    public LoginPageModel(VisitorsDbContext visitorsDbContext, IAuthService authService)
    {
        this.authService = authService;
        this.visitorsDbContext = visitorsDbContext;
        Console.WriteLine("ASP PAGE OPENED");
    }
    public void OnGet()
    {
        
    }

    public void OnPostTryLogin()
    {
    }
    
    public void OnPostTryRegister()
    {
        RegistrationEventArgs registrationData = new RegistrationEventArgs();
        
        registrationData.Company = Request.Form["Company"];
        registrationData.Name = Request.Form["Name"];
        registrationData.Password = Request.Form["Password"];
        registrationData.Mail = Request.Form["Mail"];

        authService.RegisterVisitor(registrationData);
    }
}