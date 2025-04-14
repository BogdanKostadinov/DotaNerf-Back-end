using DotaNerf.Data;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class HeroRepository : IHeroRepository
{
    private readonly DataContext _context;

    public HeroRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Hero?> GetHeroByIdAsync(int id)
    {
        return await _context.Heroes.FirstOrDefaultAsync(h => h.Id == id);
    }
}
