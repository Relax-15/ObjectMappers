using AutoMapper;

namespace ObjectMappers.NestedTypeMapping;

internal class AM_NestedTypeMapping
{
    public static IMapper mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, UserDTO>();
            cfg.CreateMap<Address, AddressDTO>();
        })
        .CreateMapper();

    public static UserDTO Map(User source)
    {
        var destination = mapper.Map<UserDTO>(source);

        return destination;
    }
}
