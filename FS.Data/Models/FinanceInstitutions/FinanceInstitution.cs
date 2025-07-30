// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.FinanceInstitutions;

using FinanceTypes;

public class FinanceInstitution(string name = "") : Model<int>, IFinanceInstitution
{
    [ShortTextLengthValidation(nameof(FinanceInstitution), nameof(Name))]
    public string Name { get; set; } = name;

    public required IEnumerable<IFinanceType> FinanceTypes { get; set; }
}