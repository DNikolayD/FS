// ReSharper disable MissingXmlDoc

namespace FS.Data.Models.Balances;

using Currencies;

public class Balance(ICurrency currency, decimal value = 0) : Model<int>, IBalance
{
    [ValueValidation(nameof(Balance), nameof(Value))]
    public decimal Value { get; set; } = value;

    public int CurrencyId  => Currency.Id; 
    
    public required ICurrency Currency { get; set; } = currency;
}