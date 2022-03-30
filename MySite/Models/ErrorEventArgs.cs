namespace MySite.Models;

public class ErrorEventArgs : EventArgs, IDataModel
{
    public string? ErrorMessage;
    public int? ErrorCode;
}