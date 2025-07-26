using FS.Reusable.Attributes;
using FS.Data.Base;
using FS.Data.Models.Currencies;
using FS.Reusable.Attributes.ErrorHandlingAtrtibutes;

namespace FS.Data.Models.Balances
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    public class Balance(decimal value = 0) : Model<int>, IBalance
    {
        /// <summary>
        /// 
        /// </summary>
        [ValueValidation(nameof(Balance), nameof(Value))]
        public decimal Value { get; set; } = value;

        /// <summary>
        /// 
        /// </summary>
        public int CurrencyId  => Currency.Id; 
        
        /// <summary>
        /// 
        /// </summary>
        public required ICurrency Currency { get; set; }
    }
}
