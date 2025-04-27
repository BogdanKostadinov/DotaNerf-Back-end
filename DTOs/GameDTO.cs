using DotaNerf.Entities;
using System.ComponentModel.DataAnnotations;

namespace DotaNerf.DTOs;

public class GameDTO
{
    public Guid Id { get; set; }
    public TeamName WinningTeam { get; set; }
    public required TeamDTO RadiantTeam { get; set; }
    public required TeamDTO DireTeam { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime LastModified { get; set; }
    public required string Duration { get; set; }
}

public class CreateGameDTO
{
    public TeamName WinningTeam { get; set; }
    public required CreateTeamDTO RadiantTeam { get; set; }
    public required CreateTeamDTO DireTeam { get; set; }

    [RegularExpression(@"^([0-9]{2}):([0-5][0-9]):([0-5][0-9])$",
    ErrorMessage = "Duration must be in the format HH:MM:SS")]
    public required string Duration { get; set; }
}

public class UpdateGameDTO
{
    public Guid Id { get; set; }
    public required UpdateTeamDTO RadiantTeam { get; set; }
    public required UpdateTeamDTO DireTeam { get; set; }
}