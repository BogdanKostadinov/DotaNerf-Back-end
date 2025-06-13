using DotaNerf.Data;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;

    public UserRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _context.Users
            .AsNoTracking()
            .ToListAsync();
    }

    public Task<User?> GetUserByIdAsync(Guid id)
    {
        var user = _context.Users.AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == id);

        return user ?? throw new KeyNotFoundException($"User with ID {id} not found.");
    }

    public Task<User?> GetUserByEmailAsync(string email)
    {
        var user = _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Email == email);

        return user;
    }
}
