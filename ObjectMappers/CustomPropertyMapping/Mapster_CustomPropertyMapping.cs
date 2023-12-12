using Mapster;


namespace ObjectMappers.CustomPropertyMapping;

public class Mapster_CustomPropertyMapping
{
    public static void Initialize()
    {
        TypeAdapterConfig<User, UserDTO>
            .NewConfig()
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");
    }

    public static UserDTO Map(User source)
    {
        var destination = source.Adapt<UserDTO>();

        return destination;
    }
}
