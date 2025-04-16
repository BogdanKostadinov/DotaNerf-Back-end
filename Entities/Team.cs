using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotaNerf.Entities;

public class Team
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public TeamName Name { get; set; }
    public Guid? GameId { get; set; }

    public List<Player> Players { get; set; } = new();

    [JsonIgnore]
    public Game Game { get; set; } = null!;
}

public enum TeamName
{
    Radiant,
    Dire
}
