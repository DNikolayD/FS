namespace FS.Data.Models.Items.CartItems;

/// <summary>
/// Interface for the items in the users "to buy" list.
/// </summary>
public interface ICartItem : IItem
{
    /// <summary>
    /// The quantity of the item
    /// </summary>
    public int Quantity { get; set; }

    public float Price { get; set; }

    public float TotalPrice { get; }


}