

using AutoMapper;

namespace ObjectMappers.ObjectFlattening;

public class AM_ObjectFlattening
{
    public static IMapper Mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, UserDTO>();
        })
        .CreateMapper();

    public static UserDTO Map(User source)
    {
        var destination = Mapper.Map<UserDTO>(source);

        return destination;
    }
}