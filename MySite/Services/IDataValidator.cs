using MySite.Models;

namespace MySite.Services;

public interface IDataValidator
{
    public bool ValidateData(RegistrationEventArgs data);
    public bool ValidateData(LoginEventArgs data);
    
}