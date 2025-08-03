// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.Items;

using Categories;
using Measurements;
using Packagings;
using Partners;

public abstract class Item(IEnumerable<IPartner> suppliers, IPackaging? packaging, ICategory category, IMeasurement measurement, DateTime? expiration, int minimumToBuy, string name = "") : Model<int>, IItem
{
    [ShortTextLengthValidation(nameof(Item), nameof(Name))]
    public string Name { get; set; } = name;

    public int MinimumToBuy { get; set; } = minimumToBuy;

    public DateTime? Expiration { get; set; } = expiration;

    public int MeasurementId => Measurement.Id;

    public required IMeasurement Measurement { get; set; } = measurement;

    public int? PackagingId => Packaging?.Id;

    public IPackaging? Packaging { get; set; } = packaging;

    public int CategoryId => Category.Id;

    public required ICategory Category { get; set; } = category;

    public required IEnumerable<IPartner> Suppliers { get; set; } = suppliers;
}