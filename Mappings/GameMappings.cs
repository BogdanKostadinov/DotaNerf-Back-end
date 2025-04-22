using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Entities;

namespace DotaNerf.Mappings;

public class GameMappings : Profile
{
    public GameMappings()
    {
        CreateMap<CreateGameDTO, Game>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.RadiantTeam, opt => opt.MapFrom(src => src.RadiantTeam))
            .ForMember(dest => dest.DireTeam, opt => opt.MapFrom(src => src.DireTeam));

        CreateMap<UpdateGameDTO, Game>()
            .ForMember(dest => dest.WinningTeam, opt => opt.Ignore())
            .ForMember(dest => dest.RadiantTeam, opt => opt.MapFrom(src => src.RadiantTeam))
            .ForMember(dest => dest.DireTeam, opt => opt.MapFrom(src => src.DireTeam));

        CreateMap<Game, GameDTO>()
            .ForMember(dest => dest.RadiantTeam, opt => opt.MapFrom(src => src.RadiantTeam))
            .ForMember(dest => dest.DireTeam, opt => opt.MapFrom(src => src.DireTeam));
    }
}
