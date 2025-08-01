using FS.Data.Models.Categories;
using FS.Data.Models.Measurements;
using FS.Data.Models.Packegings;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Items.InventoryItems
{
    public class InventoryItem(IEnumerable<IPartner> suppliers, IPackaging? packaging, ICategory category, IMeasurement measurement, DateTime? expiration, int minimumToBuy, string name = "", int quantity = 0) : Item(suppliers: suppliers, packaging: packaging, category: category, measurement: measurement, expiration: expiration, minimumToBuy: minimumToBuy, name: name), IInventoryItem
    {
        private int _quantity = quantity;

        [ValueValidation(nameof(InventoryItem), nameof(Quantity))]
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
