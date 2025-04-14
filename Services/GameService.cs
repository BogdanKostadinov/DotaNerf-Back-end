using DotaNerf.DTOs;
using DotaNerf.Entities;
using DotaNerf.Interfaces;

namespace DotaNerf.Services;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;
    private readonly IPlayerRepository _playerRepository;
    private readonly IHeroRepository _heroRepository;

    public GameService(
        IGameRepository gameRepository,
        IPlayerRepository playerRepository,
        IHeroRepository heroRepository)
    {
        _gameRepository = gameRepository;
        _playerRepository = playerRepository;
        _heroRepository = heroRepository;
    }

    public async Task<Guid> CreateGameAsync(CreateGameDTO createGameDto)
    {
        // Validate the incoming data
        if (createGameDto == null)
        {
            throw new ArgumentNullException(nameof(createGameDto));
        }
        if (createGameDto.RadiantTeam == null || createGameDto.DireTeam == null)
        {
            throw new ArgumentException("Both RadiantTeam and DireTeam are required");
        }
        if (!createGameDto.RadiantTeam.Players.Any() || !createGameDto.DireTeam.Players.Any())
        {
            throw new ArgumentException("Both teams must have players");
        }

        // Create a new game entity
        var newGame = new Game
        {
            DateCreated = DateTime.UtcNow,
            WinningTeam = createGameDto.WinningTeam,
            RadiantTeam = new Team
            {
                Id = Guid.NewGuid(),
                Name = createGameDto.RadiantTeam.Name,
                Players = new List<Player>()
            },
            DireTeam = new Team
            {
                Id = Guid.NewGuid(),
                Name = createGameDto.DireTeam.Name,
                Players = new List<Player>()
            },
            PlayerGames = new List<PlayerGame>()
        };

        // Process RadiantTeam players
        foreach (var playerDto in createGameDto.RadiantTeam.Players)
        {
            var existingPlayer = await _playerRepository.GetPlayerByIdAsync(playerDto.Id);
            var existingHero = await _heroRepository.GetHeroByIdAsync(playerDto.PlayerStats.HeroPlayedId);

            if (existingHero == null)
            {
                throw new KeyNotFoundException($"Hero with ID {playerDto.PlayerStats.HeroPlayedId} not found in RadiantTeam.");
            }

            if (existingPlayer != null)
            {
                // Append new PlayerStats to the existing player
                existingPlayer.PlayerStats.Add(new PlayerStats
                {
                    GameId = newGame.Id,
                    TeamId = newGame.RadiantTeam.Id,
                    HeroPlayedId = existingHero.Id,
                    Kills = playerDto.PlayerStats.Kills,
                    Deaths = playerDto.PlayerStats.Deaths,
                    Assists = playerDto.PlayerStats.Assists
                });
                UpdatePlayerGameStats(existingPlayer.PlayerDetails, newGame.WinningTeam == createGameDto.RadiantTeam.Name);
                newGame.RadiantTeam.Players.Add(existingPlayer);

                var playerGame = new PlayerGame
                {
                    PlayerId = existingPlayer.Id,
                    GameId = newGame.Id,
                };

                newGame.PlayerGames.Add(playerGame);
            }
            else
            {
                throw new KeyNotFoundException($"Player with ID {playerDto.Id} not found in RadiantTeam.");
            }
        }

        // Process DireTeam players (similar code as RadiantTeam)
        foreach (var playerDto in createGameDto.DireTeam.Players)
        {
            var existingPlayer = await _playerRepository.GetPlayerByIdAsync(playerDto.Id);
            var existingHero = await _heroRepository.GetHeroByIdAsync(playerDto.PlayerStats.HeroPlayedId);

            if (existingHero == null)
            {
                throw new KeyNotFoundException($"Hero with ID {playerDto.PlayerStats.HeroPlayedId} not found in Dire Team.");
            }

            if (existingPlayer != null)
            {
                existingPlayer.PlayerStats.Add(new PlayerStats
                {
                    GameId = newGame.Id,
                    TeamId = newGame.DireTeam.Id,
                    HeroPlayedId = existingHero.Id,
                    Kills = playerDto.PlayerStats.Kills,
                    Deaths = playerDto.PlayerStats.Deaths,
                    Assists = playerDto.PlayerStats.Assists
                });
                UpdatePlayerGameStats(existingPlayer.PlayerDetails, newGame.WinningTeam == createGameDto.DireTeam.Name);
                newGame.DireTeam.Players.Add(existingPlayer);

                var playerGame = new PlayerGame
                {
                    PlayerId = existingPlayer.Id,
                    GameId = newGame.Id,
                };

                newGame.PlayerGames.Add(playerGame);
            }
            else
            {
                throw new KeyNotFoundException($"Player with ID {playerDto.Id} not found in DireTeam.");
            }
        }

        // Save the game
        await _gameRepository.CreateGameAsync(newGame);

        return newGame.Id;
    }

    private void UpdatePlayerGameStats(PlayerDetails playerDetails, bool isWinner)
    {
        playerDetails.TotalGames++;
        if (isWinner)
        {
            playerDetails.GamesWon++;
        }
        else
        {
            playerDetails.GamesLost++;
        }
    }
}
