namespace DotaNerf.DTOs;

public class UserDTO
{
    public Guid Id { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
}
