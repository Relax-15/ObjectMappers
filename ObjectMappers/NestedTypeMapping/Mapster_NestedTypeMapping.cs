using Mapster;


namespace ObjectMappers.NestedTypeMapping;
public class Mapster_NestedTypeMapping
{
    public static UserDTO Map(User source)
    {
        UserDTO dest = source.Adapt<UserDTO>();

        return dest;
    }
}
