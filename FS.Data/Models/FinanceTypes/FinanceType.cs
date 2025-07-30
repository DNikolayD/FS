// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.FinanceTypes
{
    public class FinanceType(string name = "") : Model<int>, IFinanceType
    {
        [ShortTextLengthValidation(nameof(FinanceType), nameof(Name))]
        public string Name { get; set; } = name;
    }
}
