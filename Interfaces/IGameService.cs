using DotaNerf.DTOs;

namespace DotaNerf.Interfaces;

public interface IGameService
{
    Task<Guid> CreateGameAsync(CreateGameDTO createGameDto);
}
