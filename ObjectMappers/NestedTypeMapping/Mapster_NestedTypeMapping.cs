using Mapster;


namespace ObjectMappers.NestedTypeMapping;
internal class Mapster_NestedTypeMapping
{
    public static UserDTO Map(User source)
    {
        UserDTO dest = source.Adapt<UserDTO>();

        return dest;
    }
}
