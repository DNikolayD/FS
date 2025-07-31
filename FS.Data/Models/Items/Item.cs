namespace FS.Data.Models.Items;

using Categories;
using Measurements;
using Packegings;
using Partners;

public abstract class Item(IEnumerable<IPartner> suppliers, IPackaging? packaging, ICategory category, IMeasurement measurement, DateTime? expiration, float? minimumToBuy = null, string name = "") : Model<string>, IItem
{
    [ShortTextLengthValidation(nameof(Item), nameof(Name))]
    public string Name { get; set; } = name;

    public float? MinimumToBuy { get; set; } = minimumToBuy;

    public DateTime? Expiration { get; set; } = expiration;

    public int MeasurementId => Measurement.Id;

    public required IMeasurement Measurement { get; set; } = measurement;

    public int? PackagingId => Packaging?.Id;

    public IPackaging? Packaging { get; set; } = packaging;

    public int CategoryId => Category.Id;

    public required ICategory Category { get; set; } = category;

    public required IEnumerable<IPartner> Suppliers { get; set; } = suppliers;
}