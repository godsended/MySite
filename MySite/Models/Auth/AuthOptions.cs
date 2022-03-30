using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace MySite.Models;

public class AuthOptions
{
    public const string Issuer = "MySite"; // издатель токена
    public const string Audience = "MySiteClient"; // потребитель токена
    const string Key = "qwertyuiopasd1fghjklzxcvbnm1";   // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
}