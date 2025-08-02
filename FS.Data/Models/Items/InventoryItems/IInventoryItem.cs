namespace FS.Data.Models.Items.InventoryItems;

/// <summary>
/// An interface for items in the user's inventory.
/// </summary>
public interface IInventoryItem : IItem
{
    /// <summary>
    /// The quantity available in the user's inventory.
    /// </summary>
    public int QuantityAvailable { get; set; }
}