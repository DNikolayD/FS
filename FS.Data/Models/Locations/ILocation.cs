namespace FS.Data.Models.Locations;

using Countries;

/// <summary>
/// Interface used to hold information for the location of the "Partners"
/// </summary>
public interface ILocation: IModel<int>
{
    public string Address { get; set; }

    public int CountryId { get; }

    public ICountry Country { get; set; }
}