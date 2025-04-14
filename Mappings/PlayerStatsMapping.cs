using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Entities;

namespace DotaNerf.Mappings;

public class PlayerStatsMapping : Profile
{
    public PlayerStatsMapping()
    {
        CreateMap<PlayerStats, PlayerStatsDTO>();
        CreateMap<CreatePlayerStatsDTO, PlayerStats>()
           .ForMember(dest => dest.Id, opt => opt.Ignore())
           .ForMember(dest => dest.GameId, opt => opt.Ignore())
           .ForMember(dest => dest.HeroPlayed, opt => opt.Ignore());
    }
}
