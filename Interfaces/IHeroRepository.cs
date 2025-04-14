using DotaNerf.Entities;

namespace DotaNerf.Interfaces;

public interface IHeroRepository
{
    Task<Hero?> GetHeroByIdAsync(int id);
}
