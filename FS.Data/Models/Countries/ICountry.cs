namespace FS.Data.Models.Countries;

/// <summary>
/// Interface for Country. Used to specify the location of a Partner.
/// </summary>
public interface ICountry : IModel<int>
{
    /// <summary>
    /// Name of the Country.
    /// </summary>
    string Name { get; set; }
}