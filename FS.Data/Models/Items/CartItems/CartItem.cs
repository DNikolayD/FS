// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Items.CartItems;

using Categories;
using Currencies;
using Measurements;
using Packegings;
using Partners;

public class CartItem(IEnumerable<IPartner> suppliers, ICurrency currency, IPackaging? packaging, ICategory category, IMeasurement measurement, DateTime? expiration, int minimumToBuy, string name = "", int quantityToBeOrdered = 1, float price = 0.00f) : Item(suppliers: suppliers, packaging: packaging,  category: category, measurement: measurement, expiration: expiration, minimumToBuy: minimumToBuy, name: name), ICartItem
{
    [ValueValidation(nameof(CartItem), nameof(QuantityToBeOrdered))]
    public int QuantityToBeOrdered { get; set; } = quantityToBeOrdered;

    [ValueValidation(nameof(CartItem), nameof(Price))]
    public float Price { get; set; } = price;

    public float TotalPrice => QuantityToBeOrdered * Price;

    public int CurrencyId => Currency.Id;

    public ICurrency Currency { get; set; } = currency;
}