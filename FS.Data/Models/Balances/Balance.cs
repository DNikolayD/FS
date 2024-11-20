using FS.Data.Attributes;
using FS.Data.Base;
using FS.Data.Models.Currencies;

namespace FS.Data.Models.Balances
{
    public class Balance(decimal value = 0) : Model<int>, IBalance
    {
        private decimal _value = value;

        [ValueValidation(nameof(Balance), nameof(Value))]
        public decimal Value { get => _value; set => _value = value; }
        
        public int CurrencyId  => Currency.Id; 
        
        public required ICurrency Currency { get; set; }
    }
}
