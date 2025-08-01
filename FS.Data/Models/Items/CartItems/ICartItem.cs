using FS.Data.Models.Currencies;

namespace FS.Data.Models.Items.CartItems;

/// <summary>
/// Interface for the items in the user's "to buy" list.
/// </summary>
public interface ICartItem : IItem
{
    /// <summary>
    /// The quantity of the item.
    /// </summary>
    public int QuantityToBeOrdered { get; set; }

    /// <summary>
    /// The price per quantity.
    /// </summary>
    public float Price { get; set; }

    /// <summary>
    /// Total price of the item. Quantity * Price.
    /// </summary>
    public float TotalPrice { get; }

    /// <summary>
    /// The id of the currency in which the item will be bought.
    /// </summary>
    public int CurrencyId { get; }
    
    /// <summary>
    /// The currency itself.
    /// </summary>
    public ICurrency Currency { get; set; }
}