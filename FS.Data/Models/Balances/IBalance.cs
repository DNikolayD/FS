using FS.Data.Base;
using FS.Data.Models.Currencies;

namespace FS.Data.Models.Balances
{
    public interface IBalance : IModel<int>
    {
        public decimal Value { get; set; }
        
        public int CurrencyId { get; }

        public ICurrency Currency { get; set; }
    }
}
