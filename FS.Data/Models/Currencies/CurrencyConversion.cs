﻿// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Currencies
{
    public class CurrencyConversion(ICurrency fromCurrency, ICurrency toCurrency, decimal conversionRate) : Model<int>, ICurrencyConversion
    {
        public ICurrency FromCurrency { get; set; } = fromCurrency;
        public ICurrency ToCurrency { get; set; } = toCurrency;
        public decimal ConversionRate { get; set; } = conversionRate;

        public int FromCurrencyId => FromCurrency.Id;
        public int ToCurrencyId => ToCurrency.Id;
    }
}
