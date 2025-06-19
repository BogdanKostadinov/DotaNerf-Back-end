using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.Extensions.Options;

namespace DotaNerf.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;
    private readonly IOptions<AuthenticationOptions> _authOptions;

    public AuthenticationService(IUserRepository userRepository, IOptions<AuthenticationOptions> authOptions)
    {
        _userRepository = userRepository;
        _authOptions = authOptions;
    }

    public async Task<User?> AuthenticateAsync(string email, string password)
    {
        var user = await _userRepository.GetUserByEmailAsync(email);
        if (user == null) return null;

        return _userRepository.VerifyPassword(password, user.Password) ? user : null;
    }
}