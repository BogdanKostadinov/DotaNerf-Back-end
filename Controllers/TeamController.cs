using DotaNerf.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotaNerf.Controllers;

[ApiController]
[Route("/teams")]
public class TeamController : ControllerBase
{
    private readonly ITeamRepository _teamRepository;

    public TeamController(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    [HttpGet(Name = "GetTeams")]
    public async Task<IActionResult> GetTeamsAsync()
    {
        var teams = _teamRepository.GetTeamsAsync();

        if (!teams.Result.Any())
        {
            return NoContent();
        }

        return Ok(teams);
    }

    [HttpGet("{id}", Name = "GetTeam")]
    public async Task<IActionResult> GetTeamAsync(Guid id)
    {
        var team = await _teamRepository.GetTeamAsync(id);
        if (team is null)
        {
            return NotFound();
        }
        return Ok(team);
    }
    [HttpDelete("{id}", Name = "DeleteTeam")]
    public async void DeleteTeamAsync(Guid id)
    {
        await _teamRepository.DeleteTeamAsync(id);
    }
}
