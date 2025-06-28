using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotaNerf.Controllers;

[ApiController]
[Route("/players")]
public class PlayerController : ControllerBase
{
    private readonly IPlayerRepository _playerRepository;
    private readonly IMapper _mapper;

    public PlayerController(IPlayerRepository playerRepository, IMapper mapper)
    {
        _playerRepository = playerRepository;
        _mapper = mapper;
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

    [HttpPost(Name = "CreatePlayer")]
    public async Task<IActionResult> CreatePlayerAsync([FromBody] CreateNewPlayerDTO request)
    {
        var player = await _playerRepository.CreatePlayerAsync(request);

        return Ok(_mapper.Map<PlayerDTO>(player));
    }
}
