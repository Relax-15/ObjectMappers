
using AutoMapper;

namespace ObjectMappers.CustomPropertyMapping;

public class AM_CustomPropertyMapping
{
    public static IMapper Mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, UserDTO>()
                .ForMember(
                    dest => dest.FullName,
                    config => config.MapFrom(src => $"{src.FirstName} {src.LastName}"
                    ));
        })
        .CreateMapper();

    public static UserDTO Map(User source)
    {
        var destination = Mapper.Map<UserDTO>(source);

        return destination;
    }
}
