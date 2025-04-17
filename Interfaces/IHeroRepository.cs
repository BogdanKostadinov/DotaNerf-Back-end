using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface IHeroRepository
{
    Task<IEnumerable<Hero>> GetHeroesAsync();
    Task<Hero?> GetHeroByIdAsync(int id);
}
