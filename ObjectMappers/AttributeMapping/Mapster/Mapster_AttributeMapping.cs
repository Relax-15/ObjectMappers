using Mapster;

namespace ObjectMappers.AttributeMapping.Mapster;
public class Mapster_AttributeMapping
{
    public static UserDTO Map(User source)
    {
        var destination = source.Adapt<UserDTO>();

        return destination;
    }
}