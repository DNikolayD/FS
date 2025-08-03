//ReSharper disable MissingXmlDoc 
namespace FS.Data.Models.Items.InventoryItems;

using Categories;
using Measurements;
using Packagings;
using Partners;

public class InventoryItem(IEnumerable<IPartner> suppliers, IPackaging? packaging, ICategory category, IMeasurement measurement, DateTime? expiration, int minimumToBuy, string name = "", int quantity = 0) : Item(suppliers: suppliers, packaging: packaging, category: category, measurement: measurement, expiration: expiration, minimumToBuy: minimumToBuy, name: name), IInventoryItem
{
    [ValueValidation(nameof(InventoryItem), nameof(QuantityAvailable))]
    public int QuantityAvailable { get; set; } = quantity;
}