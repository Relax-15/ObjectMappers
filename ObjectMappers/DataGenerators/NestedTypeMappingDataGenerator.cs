﻿

using Bogus;
using ObjectMappers.NestedTypeMapping;

namespace ObjectMappers.DataGenerators;

public class NestedTypeMappingDataGenerator
{
    public static List<User> GetSources(int count = 1000)
    {
        var fakerA = new Bogus.DataSets.Address();
        var faker = new Faker<User>()
            .Rules((f, o) =>
            {
                o.Id = f.Random.Number();
                o.FirstName = f.Name.FirstName();
                o.LastName = f.Name.LastName();
                o.Email = f.Person.Email;
                o.Address = new Address()
                {
                    AddressLine1 = f.Address.BuildingNumber(),
                    City = f.Address.City(),
                    State = f.Address.State(),
                    Country = f.Address.Country(),
                    ZipCode = f.Address.ZipCode()
                };
            });
        return faker.Generate(count);
    }
}
