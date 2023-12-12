using Mapster;


namespace ObjectMappers.ReverseMappingAndUnflattening;

public class Mapster_ReverseMapping
{
    public static void Initialize()
    {
        TypeAdapterConfig<User, UserDTO>
            .NewConfig()
            .TwoWays()
            .Map(dest => dest.EmailAddress, src => src.Email);
    }

    public static User Map(UserDTO destination)
    {
        var source = destination.Adapt<User>();

        return source;
    }
}