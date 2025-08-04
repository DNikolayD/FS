// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.TransactionTypes;

public class TransactionType(string name = "") : Model<int>, ITransactionType
{
    [ShortTextLengthValidation(nameof(TransactionType), nameof(Name))]
    public string Name { get; set; } = name;
}