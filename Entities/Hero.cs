using System.ComponentModel.DataAnnotations;

namespace DotaNerf.Entities;

public class Hero
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
}
