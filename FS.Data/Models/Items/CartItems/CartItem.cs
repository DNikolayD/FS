using FS.Data.Models.Categories;
using FS.Data.Models.Measurements;
using FS.Data.Models.Packegings;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Items.CartItems
{
    public class CartItem(IEnumerable<IPartner> suppliers, IPackaging? packaging, ICategory category, IMeasurement measurement, DateTime? expiration, float? minimumToBuy, string name = "", int quantity = 1, float price = 0) : Item(suppliers: suppliers, packaging: packaging, category: category, measurement: measurement, expiration: expiration, minimumToBuy: minimumToBuy, name: name), ICartItem
    {
        [ValueValidation(nameof(CartItem), nameof(Quantity))]
        public int Quantity { get; set; } = quantity;

        [ValueValidation(nameof(CartItem), nameof(Price))]
        public float Price { get; set; } = price;

        public float TotalPrice => Quantity * Price;
    }
}
