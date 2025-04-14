﻿using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotaNerf.Controllers;

[ApiController]
[Route("/games")]
public class GameController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IGameService _gameService;
    private readonly IGameRepository _gameRepository;
    public GameController(
           IMapper mapper, 
           IGameService gameService,
           IGameRepository gameRepository)
    {
        _mapper = mapper;
        _gameService = gameService;
        _gameRepository = gameRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetGamesAsync()
    {
        var games = await _gameRepository.GetGamesAsync();

        var gameDtos = games.Select(game => _mapper.Map<GameDTO>(game, opt => opt.Items["GameId"] = game.Id)).ToList();

        if (!games.Any())
        {
            return NotFound("No games found in the database.");
        }

        return Ok(gameDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetGameAsync(Guid id)
    {
        var game = await _gameRepository.GetGameByIdAsync(id);

        if (game == null)
        {
            return NotFound();
        }

        var gameDto = _mapper.Map<GameDTO>(game, opt => opt.Items["GameId"] = id);
        return Ok(gameDto);
    }

    [HttpPost]
    public async Task<IActionResult> CreateGame([FromBody] CreateGameDTO createGameDto)
    {
        try
        {
            var gameId = await _gameService.CreateGameAsync(createGameDto);
            return Ok(new { Message = "Game created successfully", GameId = gameId });
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (KeyNotFoundException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred while creating the game. {ex}");
        }
    }
}

