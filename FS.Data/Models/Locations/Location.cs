// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Locations;

using Countries;

public class Location(ICountry country, string address = "") : Model<int>, ILocation
{
    [LongTextLengthValidation(nameof(Location), nameof(Address))]
    public string Address { get; set; } = address;

    public int CountryId => Country.Id;

    public ICountry Country { get; set; } = country;

    public Location(string address = "") : this(new Country(), address)
    {
    }
}