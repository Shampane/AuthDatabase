using AuthDatabase.Authentication.Models;
using AutoMapper;

namespace AuthDatabase.Authentication;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserRegistrationDto, UserEntity>()
            .ForMember(u => u.UserName, options => options.MapFrom(x => x.Email));
    }
}
