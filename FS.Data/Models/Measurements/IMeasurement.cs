namespace FS.Data.Models.Measurements;

/// <summary>
/// The unit measurement of the product, for example kilo or litter.
/// </summary>
public interface IMeasurement : IModel<int>
{
    /// <summary>
    /// The shortened name of the measurement, example kg.
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// The full name of the measurement unit.
    /// </summary>
    public string LongName { get; set; }
}