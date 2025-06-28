using AutoMapper;
using DotaNerf.Data;
using DotaNerf.DTOs;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public PlayerRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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

    public async Task<Player> CreatePlayerAsync(CreateNewPlayerDTO playerDTO)
    {
        var player = _mapper.Map<Player>(playerDTO);

        bool playerExists = await _context.Players.AnyAsync(p => p.Name == playerDTO.Name);
        if (playerExists)
        {
            throw new InvalidOperationException($"A player with the name '{playerDTO.Name}' already exists.");
        }

        await _context.Players.AddAsync(player);
        await _context.SaveChangesAsync();

        return player;
    }
}
