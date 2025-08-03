// ReSharper disable PossibleMultipleEnumeration
// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Items.TransactionItems;

using Currencies;
using Categories;
using Measurements;
using Members;
using Packagings;
using Partners;


public class TransactionItem(
    IEnumerable<IPartner> suppliers,
    IMember member,
    IPackaging packaging,
    ICategory category,
    IMeasurement measurement,
    DateTime? expiration,
    int minimumToBuy,
    ICurrency currency,
    IPartner supplier,
    string? name = "",
    int quantity = 0,
    float pricePerUnit = 0) : Item(suppliers, packaging, category, measurement, expiration, minimumToBuy, name ?? ""),
    ITransactionItem
{
    [ValueValidation(nameof(TransactionItem), nameof(Quantity))]
    public int Quantity { get; set; } = quantity;

    [ValueValidation(nameof(TransactionItem), nameof(PricePerUnit))]
    public float PricePerUnit { get; set; } = pricePerUnit;

    public float TotalPrice  => PricePerUnit * Quantity;

    public int CurrencyId => Currency.Id;

    public ICurrency Currency { get; set; } = currency;

    public int SupplierId => Supplier.Id;

    public IPartner Supplier { get; set; } =  suppliers.Any(x => x.Id == supplier.Id) ? supplier : new Partner();

    public int MemberId => Member.Id;

    public IMember Member { get; set; } = member;
}