using DotaNerf.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotaNerf.Controllers;

[ApiController]
[Route("/players")]
public class PlayerController : ControllerBase
{
    private readonly IPlayerRepository _playerRepository;

    public PlayerController(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    [HttpGet(Name = "GetPlayers")]
    public async Task<IActionResult> GetPlayersAsync()
    {
        var players = await _playerRepository.GetPlayersAsync();
        return Ok(players);
    }

    [HttpGet("{id}", Name = "GetPlayerById")]
    public async Task<IActionResult> GetPlayerByIdAsync(Guid id)
    {
        var player = await _playerRepository.GetPlayerByIdAsync(id);
        if (player is null)
        {
            return NotFound();
        }
        return Ok(player);
    }
}
