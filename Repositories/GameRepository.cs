using DotaNerf.Data;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class GameRepository : IGameRepository
{
    private readonly DataContext _context;
    private readonly IPlayerRepository _playerRepository;

    public GameRepository(DataContext context, IPlayerRepository playerRepository)
    {
        _context = context;
        _playerRepository = playerRepository;
    }


    public async Task<IEnumerable<Game>> GetGamesAsync()
    {
        return await _context.Games
            .Include(g => g.RadiantTeam)
                .ThenInclude(t => t!.Players)
                    .ThenInclude(p => p.PlayerStats)
                        .ThenInclude(ps => ps.HeroPlayed)
            .Include(g => g.DireTeam)
                .ThenInclude(t => t!.Players)
                    .ThenInclude(p => p.PlayerStats)
                        .ThenInclude(ps => ps.HeroPlayed)
            .ToListAsync();
    }

    public async Task<Game?> GetGameByIdAsync(Guid id)
    {
        return await _context.Games
            .Include(g => g.RadiantTeam)
                .ThenInclude(t => t!.Players)
                .ThenInclude(p => p.PlayerStats.Where(ps => ps.GameId == id))
                .ThenInclude(ps => ps.HeroPlayed)
            .Include(g => g.DireTeam)
                .ThenInclude(t => t!.Players)
                .ThenInclude(p => p.PlayerStats.Where(ps => ps.GameId == id))
                .ThenInclude(ps => ps.HeroPlayed)
            .FirstOrDefaultAsync(g => g.Id == id);
    }

    public async Task<IEnumerable<Game>> GetGamesForPlayerAsync(Guid id)
    {
        var player = await _playerRepository.GetPlayerByIdAsync(id);
        if (player == null)
        {
            return Enumerable.Empty<Game>();
        }

        // Get the IDs of all games the player participated in
        var gameIds = await _context.PlayerGames
            .Where(pg => pg.PlayerId == id)
            .Select(pg => pg.GameId)
            .ToListAsync();

        // Return the full game objects with all their related data
        return await _context.Games
            .Where(g => gameIds.Contains(g.Id))
            .Include(g => g.RadiantTeam)
                .ThenInclude(t => t!.Players)
                    .ThenInclude(p => p.PlayerStats)
                        .ThenInclude(ps => ps.HeroPlayed)
            .Include(g => g.DireTeam)
                .ThenInclude(t => t!.Players)
                    .ThenInclude(p => p.PlayerStats)
                        .ThenInclude(ps => ps.HeroPlayed)
            .ToListAsync();
    }

    public async Task<Game> CreateGameAsync(Game game)
    {
        await _context.Games.AddAsync(game);
        await _context.SaveChangesAsync();
        return game;
    }

}
