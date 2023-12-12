using Mapster;

namespace ObjectMappers.SimpleTypeMapping;

public class MapsterTypeMapping
{
    public static UserDTO Map(User source)
    {
        var dest = source.Adapt<UserDTO>();

        return dest;
    }
}
