using AutoMapper;


namespace ObjectMappers.CollectionMapping;

internal class AM_CollectionMapping
{
    public static IMapper Mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();

    public static List<UserDTO> Map(List<User> source)
    {
        var destination = Mapper.Map<List<UserDTO>>(source);

        return destination;
    }
}
