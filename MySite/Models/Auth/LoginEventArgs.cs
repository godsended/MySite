namespace MySite.Models;

public class LoginEventArgs : EventArgs, IDataModel
{
    public string Password { get; set; }
    public string Mail { get; set; }
}