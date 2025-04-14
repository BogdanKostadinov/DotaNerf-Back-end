using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Entities;

namespace DotaNerf.Mappings;

public class PlayerDetailMappings : Profile
{
    public PlayerDetailMappings()
    {
        CreateMap<PlayerDetails, PlayerDetailsDTO>();
        CreateMap<PlayerDetailsDTO, PlayerDetails>();
    }
}
