using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotaNerf.Entities;

public class Game
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public required TeamName WinningTeam { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime LastModified { get; set; }

    public Guid RadiantTeamId { get; set; }
    public Guid DireTeamId { get; set; }
    public Team RadiantTeam { get; set; } = null!;
    public Team DireTeam { get; set; } = null!;

    // Navigation properties
    [JsonIgnore]
    public List<PlayerGame> PlayerGames { get; set; } = new();
}
