namespace FS.Data.Models.Carts;

using Items.CartItems;
using Partners;

/// <summary>
/// Represents a list of items that the user wants to buy
/// </summary>
public interface ICart : IModel<int>
{
    /// <summary>
    /// Returns the total price of all the items in the cart.
    /// </summary>
    public float TotalPrice { get; }

    /// <summary>
    /// Holds the id of the partner.
    /// </summary>
    public int PartnerId { get; }

    /// <summary>
    /// The partner from whom the items in the cart can or will be bought.
    /// </summary>
    public IPartner Partner { get; set; }

    /// <summary>
    /// The items in the cart
    /// </summary>
    public IEnumerable<ICartItem> CartItems { get; set; }
}