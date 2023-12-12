
namespace ObjectMappers.SimpleTypeMapping;

public class UserDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null;
    public bool IsActive { get; set; }
    public string? Email { get; set; } = null;
    public string DateCreated { get; set; } = null;
}
