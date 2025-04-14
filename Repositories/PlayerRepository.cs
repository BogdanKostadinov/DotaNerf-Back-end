using DotaNerf.Data;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly DataContext _context;
    public PlayerRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Player>> GetPlayersAsync()
    {
        return await _context.Players
            .Include(p => p.PlayerDetails)
            .Include(p => p.PlayerStats)
            .ToListAsync();
    }

    public async Task<Player?> GetPlayerByIdAsync(Guid id)
    {
        return await _context.Players
            .Include(p => p.PlayerDetails)
            .Include(p => p.PlayerStats)
            .AsTracking()
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}
