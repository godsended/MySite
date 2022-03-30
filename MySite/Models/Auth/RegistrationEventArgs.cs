namespace MySite.Models;

public class RegistrationEventArgs : EventArgs, IDataModel
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Mail { get; set; }
    public string Company { get; set; }
}