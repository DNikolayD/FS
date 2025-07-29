namespace FS.Data.Models.Balances;

using Currencies;

/// <summary>
/// Object that represents the monetary balance of the user, in a bank account or in cash.
/// </summary>
public interface IBalance : IModel<int>
{
    /// <summary>
    /// The amount of the balance in the currency of the balance. Restricted by the minimum and maximum allowed values defined in Reusable.Constants.
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// Holds the id of the currency of the balance.
    /// </summary>
    public int CurrencyId { get; }

    /// <summary>
    /// The currency of the balance. Currency is a class defined in the Currencies namespace.
    /// </summary>
    public ICurrency Currency { get; set; }
}