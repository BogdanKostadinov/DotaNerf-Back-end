using AutoMapper;
using DotaNerf.Data;
using DotaNerf.DTOs;
using DotaNerf.Entities;
using DotaNerf.Interfaces;
using DotaNerf.Services;
using Microsoft.EntityFrameworkCore;

namespace DotaNerf.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    private readonly PasswordHashingService _passwordHashingService;

    public UserRepository(DataContext context, 
                          IMapper mapper, 
                          PasswordHashingService passwordHashingService)
    {
        _context = context;
        _mapper = mapper;
        _passwordHashingService = passwordHashingService;
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

    public async Task<User> CreateUserAsync(CreateUserDTO userDto)
    {
        var user = _mapper.Map<User>(userDto);
        var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == userDto.Email);
        if (existingUser != null)
        {
            throw new InvalidOperationException("A user with this email already exists.");
        }

        user.Password = _passwordHashingService.HashPassword(userDto.Password);

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        return _passwordHashingService.VerifyPassword(password, hashedPassword);
    }
}
