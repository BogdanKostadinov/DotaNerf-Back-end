using DotaNerf.Data;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class TeamRepository : ITeamRepository
{
    private readonly DataContext _context;
    public TeamRepository(DataContext context)
    {
        _context = context;
    }
    public async Task<Team> GetTeamAsync(Guid id)
    {
        var team = await _context.Teams.FirstOrDefaultAsync(t => t.Id == id);
        if (team == null)
        {
            throw new KeyNotFoundException($"Team with ID {id} not found.");
        }
        return team;
    }
    public async Task DeleteTeamAsync(Guid id)
    {
        var team = GetTeamAsync(id).Result;

        _context.Teams.Remove(team);
        await _context.SaveChangesAsync();
    }
}
