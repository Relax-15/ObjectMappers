
using AutoMapper;

namespace ObjectMappers.ReverseMappingAndUnflattening;

public class AM_ReverseMapping
{
    public static IMapper Mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, UserDTO>()
                .ForMember(dest => dest.EmailAddress, config => config.MapFrom(src => src.Email))
                .ReverseMap();
        })
        .CreateMapper();

    public static User Map(UserDTO destination)
    {
        var source = Mapper.Map<User>(destination);

        return source;
    }

}
