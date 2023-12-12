﻿

namespace ObjectMappers.CustomPropertyMapping;

public class UserDTO
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
