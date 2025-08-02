
namespace FS.Data.Models.Items.TransactionItems;

using Partners;
using Members;
using Currencies;

/// <summary>
/// The interface representing that thr user has bought.
/// </summary>
public interface ITransactionItem : IItem
{
    /// <summary>
    /// Represents the bought amount in the chosen measurement unit.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// The cost of a single unit of the bought item in the chosen currency.
    /// </summary>
    public float PricePerUnit { get; set; }

    /// <summary>
    /// The total cost of the bought item on the chosen currency.
    /// </summary>
    public float TotalPrice { get; }

    /// <summary>
    /// The id of the chosen currency.
    /// </summary>
    public int CurrencyId { get; }

    /// <summary>
    /// The chosen currency.
    /// </summary>
    public ICurrency Currency { get; set; }

    /// <summary>
    /// The id of the supplier, form whom the item was bought.
    /// </summary>
    public int SupplierId { get; }

    /// <summary>
    /// The supplier, from whom the item was bought.
    /// </summary>
    public IPartner Supplier { get; set; }

    /// <summary>
    /// The id of the member, for whom the item was bought, in case of multi-member household.
    /// </summary>
    public int MemberId { get; }

    /// <summary>
    /// The member itself.
    /// </summary>
    public IMember Member { get; set; }
}