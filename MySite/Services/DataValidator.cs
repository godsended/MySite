using System.ComponentModel.DataAnnotations;
using MySite.Models;

namespace MySite.Services;

public class DataValidator : IDataValidator
{
    public bool ValidateData(RegistrationEventArgs data)
    {
        if (string.IsNullOrEmpty(data.Mail) || string.IsNullOrEmpty(data.Name) || string.IsNullOrEmpty(data.Password))
            return false;

        if (!new EmailAddressAttribute().IsValid(data.Mail))
            return false;
        if(data.Name.Length < 2)
        return true;
    }

    public bool ValidateData(LoginEventArgs data)
    {
        
    }
}