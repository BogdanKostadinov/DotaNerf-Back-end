using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Entities;

namespace DotaNerf.Mappings;

public class HeroMappings : Profile
{
    public HeroMappings()
    {
        CreateMap<Hero, HeroDTO>();
        CreateMap<CreateHeroDTO, Hero>();
    }
}
