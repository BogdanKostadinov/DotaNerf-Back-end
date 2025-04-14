using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface IPlayerRepository
{
    Task<IEnumerable<Player>> GetPlayersAsync();
    Task<Player?> GetPlayerByIdAsync(Guid id);
}
