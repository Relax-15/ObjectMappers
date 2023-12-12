using Bogus;
using ObjectMappers.SimpleTypeMapping;

namespace ObjectMappers.DataGenerators;

public class SimpleTypeMappingDataGenerator
{
    public static List<User> GetSources(int count = 100)
    {
        var faker = new Faker<User>()
            .Rules((f, o) =>
            {
                o.Id = f.Random.Number();
                o.Name = f.Name.FullName();
                o.Email = f.Person.Email;
                o.IsActive = f.Random.Bool();
                o.DateCreated = DateTime.Now;
            });
        return faker.Generate(count);
    }
}
