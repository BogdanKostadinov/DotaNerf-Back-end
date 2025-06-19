using DotaNerf.Entities;
using DotaNerf.Interfaces;

namespace DotaNerf.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User?> AuthenticateAsync(string email, string password)
    {
        var user = await _userRepository.GetUserByEmailAsync(email);
        if (user == null) return null;

        return _userRepository.VerifyPassword(password, user.Password) ? user : null;
    }
}