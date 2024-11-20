namespace FS.Data.Models.Items.InventoryItems
{
    public interface IInventoryItem : IItem
    {
        public int Quantity { get; set; }
    }
}
