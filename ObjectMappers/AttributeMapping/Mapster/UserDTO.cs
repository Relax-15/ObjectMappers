﻿

using Mapster;

namespace ObjectMappers.AttributeMapping.Mapster;

public class UserDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    [AdaptMember("CreatedAt")]
    public string CreatedDate { get; set; } = null!;
    
}