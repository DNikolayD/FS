using FS.Reusable.Attributes;

namespace FS.Data.Models.Items.InventoryItems
{
    public class InventoryItem(int quantity = 0) : Item, IInventoryItem
    {
        private int _quantity = quantity;

        [ValueValidation(nameof(InventoryItem), nameof(Quantity))]
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
