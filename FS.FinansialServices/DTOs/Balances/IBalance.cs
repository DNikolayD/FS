using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.FinansialServices.DTOs.Base;
using FS.FinancialServices.DTOs.Currencies;

namespace FS.FinansialServices.DTOs.Balances
{
    internal interface IBalance: IModel<int>
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
