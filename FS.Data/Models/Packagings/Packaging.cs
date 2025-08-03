// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.Packagings;

public class Packaging(string name = "") : Model<int>, IPackaging
{
    [ValueValidation(nameof(Packaging), nameof(Name))]
    public string Name { get; set; } = name;
}