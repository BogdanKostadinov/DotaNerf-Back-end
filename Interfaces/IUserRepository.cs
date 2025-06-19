using DotaNerf.DTOs;
using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User?> GetUserByIdAsync(Guid id);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User> CreateUserAsync(CreateUserDTO user);
    bool VerifyPassword(string password, string hashedPassword);    
    //Task<User> UpdateUserAsync(User user);
}
