using Mapster;


namespace ObjectMappers.ObjectFlattening;

public class Mapster_ObjectFlattening
{
    public static UserDTO Map(User source)
    {
        var destination = source.Adapt<UserDTO>();

        return destination;
    }
}
