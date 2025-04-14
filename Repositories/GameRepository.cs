using DotaNerf.Data;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class GameRepository : IGameRepository
{
    private readonly DataContext _context;

    public GameRepository(DataContext context)
    {
        _context = context;
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

    public async Task<Game> CreateGameAsync(Game game)
    {
        await _context.Games.AddAsync(game);
        await _context.SaveChangesAsync();
        return game;
    }
}
