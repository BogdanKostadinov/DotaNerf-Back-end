using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface ITeamRepository
{
    Task<IEnumerable<Team>> GetTeamsAsync();
    Task<Team> GetTeamAsync(Guid id);
    Task DeleteTeamAsync(Guid id);
}
