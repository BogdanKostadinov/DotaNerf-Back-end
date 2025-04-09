﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotaNerf.Models;

public class Game
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public required TeamName WinningTeam { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    public Guid RadiantTeamId { get; set; }
    public Guid DireTeamId { get; set; }
    public Team? RadiantTeam { get; set; }
    public Team? DireTeam { get; set; }

    // Navigation properties
    [JsonIgnore]
    public List<PlayerGame> PlayerGames { get; set; } = new();
}
