using FS.FinansialServices.DTOs.Base;
using FS.FinancialServices.DTOs.Currencies;

namespace FS.FinansialServices.DTOs.Balances
{
    public class Balance : Model<int>, IBalance
    {
        public decimal Value { get; set; }
        public int CurrencyId { get; }
        public ICurrency Currency { get; set; }
    }
}
