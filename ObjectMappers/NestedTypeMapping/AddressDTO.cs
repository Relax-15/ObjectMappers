

namespace ObjectMappers.NestedTypeMapping;

internal class AddressDTO
{
    public string AddressLine1 { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
}
