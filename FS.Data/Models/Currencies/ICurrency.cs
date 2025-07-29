namespace FS.Data.Models.Currencies;

/// <summary>
/// Interface for currencies in the balances and transactions of the user
/// </summary>
public interface ICurrency : IModel<int>
{
    /// <summary>
    /// Name of the currency
    /// </summary>
    public string Name { get; set; }
}