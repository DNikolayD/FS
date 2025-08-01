namespace FS.Data.Models.Items;

using Categories;
using Measurements;
using Packegings;
using Partners;

/// <summary>
/// The interface of an abstract class that is inherited by CartItems, InventoryItems and TransactionItems.
/// </summary>
public interface IItem : IModel<int>
{
    /// <summary>
    /// The name of the item.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The minimum amount that should be ordered any time that item is ordered.
    /// </summary>
    public int MinimumToBuy { get; set; }

    /// <summary>
    /// The expiration date of the expiration of the item if it has any.
    /// </summary>
    public DateTime? Expiration { get; set; }

    /// <summary>
    /// The id for the measurement unit.
    /// </summary>
    public int MeasurementId { get; }

    /// <summary>
    /// The measurement unit of the item
    /// </summary>
    public IMeasurement Measurement { get; set; }

    /// <summary>
    /// The id of the packaging if the item has any. It can be null because it holds the packaging in which the item is used. For example shoes shouldn't have packaging.
    /// </summary>
    public int? PackagingId { get; }

    /// <summary>
    /// The packaging itself.
    /// </summary>
    public IPackaging? Packaging { get; set; }

    /// <summary>
    /// The id of the category of the items. For example, Product.
    /// </summary>
    public int CategoryId { get; }

    /// <summary>
    /// The category itself.
    /// </summary>
    public ICategory Category { get; set; }

    /// <summary>
    /// List of partners from which you can order the item.
    /// </summary>
    public IEnumerable<IPartner> Suppliers { get; set; }
}