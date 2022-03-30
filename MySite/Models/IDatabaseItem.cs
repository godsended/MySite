using System.ComponentModel.DataAnnotations;

namespace MySite.Models;

public interface IDatabaseItem : IDataModel
{
    [Key]
    public int Id { get; set; }
}