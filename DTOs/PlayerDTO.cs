using DotaNerf.Entities;

namespace DotaNerf.DTOs;

public class PlayerDTO
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public PlayerGroup PlayerGroup { get; set; }
    public required PlayerDetailsDTO PlayerDetails { get; set; }
    public List<PlayerStatsDTO> PlayerStats { get; set; } = new();
}

public class CreatePlayerDTO
{
    public Guid Id { get; set; }
    public required CreatePlayerStatsDTO PlayerStats { get; set; }
}

public class CreateNewPlayerDTO
{
    public required string Name { get; set; }
    public PlayerGroup PlayerGroup { get; set; }
    public required CreatePlayerDetailsDTO PlayerDetails { get; set; }
}

public class UpdatePlayerDTO
{
    public Guid Id { get; set; }
    public required UpdatePlayerStatsDTO PlayerStats { get; set; }
}

