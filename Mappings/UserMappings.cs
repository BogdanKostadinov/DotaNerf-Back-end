using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Entities;

namespace DotaNerf.Mappings;

public class UserMappings : Profile
{
    public UserMappings()
    {
        CreateMap<User, UserDTO>().ReverseMap();
    }
}
