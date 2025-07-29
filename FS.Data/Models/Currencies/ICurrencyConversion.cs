namespace FS.Data.Models.Currencies;
/// <summary>
/// Used for converting currencies
/// </summary>
public interface ICurrencyConversion : IModel<int>
{
    /// <summary>
    /// The id of the currency being converted
    /// </summary>
    public int FromCurrencyId { get; }

    /// <summary>
    /// The id of the currency being converted to
    /// </summary>
    public int ToCurrencyId { get; }

    /// <summary>
    /// The currency being converted
    /// </summary>
    public ICurrency FromCurrency { get; set; }

    /// <summary>
    /// The currency being converted to
    /// </summary>
    public ICurrency ToCurrency { get; set; }

    /// <summary>
    /// The conversion rate between the two currencies. Can be used as a multiplier or divisor.
    /// </summary>
    public decimal ConversionRate { get; set; }

}