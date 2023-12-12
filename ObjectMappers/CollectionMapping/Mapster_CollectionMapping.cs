using Mapster;


namespace ObjectMappers.CollectionMapping;

public class Mapster_CollectionMapping
{
    public static List<UserDTO> Map(List<User> source)
    {
        var destination = source.Adapt<List<UserDTO>>();

        return destination;
    }
}
