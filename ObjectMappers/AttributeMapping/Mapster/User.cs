using Mapster;


namespace ObjectMappers.AttributeMapping.Mapster;

[AdaptTo(nameof(UserDTO))]
[AdaptTwoWays(nameof(UserDTO))]
public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}
