using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMappers.CollectionMapping;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsActive { get; set; }
    public string Email { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}
