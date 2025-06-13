using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User?> GetUserByIdAsync(Guid id);
    Task<User?> GetUserByEmailAsync(string email);

    //Task<User> CreateUserAsync(User user);
    //Task<User> UpdateUserAsync(User user);
}
