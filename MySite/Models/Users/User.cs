using System.ComponentModel.DataAnnotations;

namespace MySite.Models;

public class User : IDatabaseItem
{
    [Key, Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Company { get; set; }
    [Required]
    public string Mail { get; set; }
    [Required]
    public string Password { get; set; }
}