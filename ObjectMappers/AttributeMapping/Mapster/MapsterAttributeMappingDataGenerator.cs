using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMappers.AttributeMapping.Mapster;
public class MapsterAttributeMappingDataGenerator
{
    public static List<User> GetSources(int count = 1000)
    {
        var faker = new Faker<User>()
            .Rules((f, o) =>
            {
                o.Id = f.Random.Number();
                o.FirstName = f.Name.FirstName();
                o.LastName = f.Name.LastName();
                o.Email = f.Person.Email;
                o.CreatedAt = DateTime.Now;
            });
        return faker.Generate(count);
    }
}
