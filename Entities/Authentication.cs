namespace DotaNerf.Entities;

public class Authentication
{
}
public class AuthenticationOptions
{
    public const string SectionName = "Authentication";

    public AdminBypassOptions AdminBypass { get; set; } = new();
}

public class AdminBypassOptions
{
    public string Email { get; set; } = string.Empty;
    public bool Enabled { get; set; } = false;
}
