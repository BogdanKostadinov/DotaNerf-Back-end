using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface IGameRepository
{
    Task<IEnumerable<Game>> GetGamesAsync();
    Task<Game?> GetGameByIdAsync(Guid id);
    Task<Game> CreateGameAsync(Game game);
}
