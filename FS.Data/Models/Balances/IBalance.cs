// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBalance.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IBalance type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FS.Data.Models.Balances
{
    using Currencies;

    /// <summary>
    /// The Balance interface.
    /// </summary>
    public interface IBalance : IModel<int>
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Gets the currency id.
        /// </summary>
        public int CurrencyId { get; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public ICurrency Currency { get; set; }
    }
}
