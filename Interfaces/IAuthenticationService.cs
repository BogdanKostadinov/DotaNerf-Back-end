using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface IAuthenticationService
{
    Task<User?> AuthenticateAsync(string email, string password);
}
