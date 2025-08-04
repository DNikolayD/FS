namespace FS.Data.Models.Partners;

using Locations;

/// <summary>
/// A business that the user buys items from.
/// </summary>
public interface IPartner : IModel<int>
{
    /// <summary>
    /// The name of the business.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The location id.
    /// </summary>
    public int LocationId { get; }

    /// <summary>
    /// The location at which the business operates.
    /// </summary>
    public ILocation Location { get; set; }
}