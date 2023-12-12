﻿

namespace ObjectMappers.NestedTypeMapping;

internal class UserDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public Address Address { get; set; } = null!;
}

