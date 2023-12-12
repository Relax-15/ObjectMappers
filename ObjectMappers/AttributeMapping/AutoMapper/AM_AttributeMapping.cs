

using AutoMapper;

namespace ObjectMappers.AttributeMapping.AutoMapper;
public class AM_AttributeMapping
{
    public static IMapper Mapper = new MapperConfiguration(cfg => cfg.AddMaps(typeof(AM_AttributeMapping).Assembly)).CreateMapper();

    public static UserDTO Map(User source)
    {
        var destination = Mapper.Map<UserDTO>(source);

        return destination;
    }
}

