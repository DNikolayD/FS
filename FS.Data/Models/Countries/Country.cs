// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.Countries;

public class Country(string name = "") : Model<int>, ICountry
{
    [ShortTextLengthValidation(nameof(Country), nameof(Name))]
    public string Name { get; set; } = name;
}