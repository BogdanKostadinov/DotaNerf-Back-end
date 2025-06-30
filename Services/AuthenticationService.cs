using DotaNerf.Entities;
using DotaNerf.Interfaces;
using Microsoft.Extensions.Options;

namespace DotaNerf.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;
    private readonly JwtTokenService _jwtTokenService;
    private readonly AuthenticationOptions _authOptions;

    public AuthenticationService(
        IUserRepository userRepository,
        JwtTokenService jwtTokenService,
        IOptions<AuthenticationOptions> authOptions)
    {
        _userRepository = userRepository;
        _jwtTokenService = jwtTokenService;
        _authOptions = authOptions.Value;
    }

    public async Task<User?> AuthenticateAsync(string email, string password)
    {
        // Handle admin bypass if enabled
        if (_authOptions.AdminBypass.Enabled && email == _authOptions.AdminBypass.Email)
        {
            var adminUser = await _userRepository.GetUserByEmailAsync(email);
            return adminUser;
        }

        var user = await _userRepository.GetUserByEmailAsync(email);
        if (user == null) return null;

        return _userRepository.VerifyPassword(password, user.Password) ? user : null;
    }

    public string GenerateJwtToken(User user)
    {
        return _jwtTokenService.GenerateToken(user);
    }
}