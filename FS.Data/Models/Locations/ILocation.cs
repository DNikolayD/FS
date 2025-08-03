namespace FS.Data.Models.Locations;

using Countries;

/// <summary>
/// Interface used to hold information for the location of the "Partners"
/// </summary>
public interface ILocation: IModel<int>
{
    /// <summary>
    /// The address of the Partner
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// The id of the country that the partner is located in.
    /// </summary>
    public int CountryId { get; }

    /// <summary>
    /// The country of the partner
    /// </summary>
    public ICountry Country { get; set; }
}