namespace DotaNerf.DTOs;

public class LoginRequest
{
    public required string Email { get; set; }
    public required string Password { get; set; }
}

public class LoginResponse
{
    public UserDTO User { get; set; } = null!;
    public string Token { get; set; } = string.Empty;
    public DateTime Expiration { get; set; }
}
