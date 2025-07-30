// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.Currencies
{
    public class Currency(string name = "") : Model<int>, ICurrency
    {
        [ShortTextLengthValidation(nameof(Currency), nameof(Name))]
        public string Name { get; set; } = name;
    }
}
