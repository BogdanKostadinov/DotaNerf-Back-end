using DotaNerf.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotaNerf.Controllers;

[ApiController]
[Route("/heroes")]
public class HeroController : ControllerBase
{
    private readonly IHeroRepository _heroRepository;

    public HeroController(IHeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }

    [HttpGet(Name = "GetHeroes")]
    public async Task<IActionResult> GetHeroesAsync()
    {
        var heroes = await _heroRepository.GetHeroesAsync();
        if (!heroes.Any())
        {
            return NotFound("No heroes found in the database.");
        }
        return Ok(heroes);
    }

    [HttpGet("{id}", Name = "GetHero")]
    public async Task<IActionResult> GetHeroAsync(int id)
    {
        var hero = await _heroRepository.GetHeroByIdAsync(id);

        if (hero is null)
        {
            return NotFound($"No hero found in the database with id: {id}");
        }

        return Ok(hero);
    }
}
