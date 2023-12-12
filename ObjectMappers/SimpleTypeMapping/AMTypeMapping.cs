

using AutoMapper;

namespace ObjectMappers.SimpleTypeMapping;

public class AMTypeMapping
{
    public static IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();

    public static UserDTO Map(User source)
    {
        var destination = mapper.Map<UserDTO>(source);

        return destination;
    }
}
