using System.ComponentModel.DataAnnotations;

namespace MySite.Models;

[Serializable]
public class Visitor : IDatabaseItem 
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Ip { get; set; } = null!;
    public DateTime VisitTime { get; set; } 
    public int? UserId { get; set; }
}