using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.FinansialServices.DTOs.Balances;
using FS.FinansialServices.DTOs.Base;
using FS.Reusable.Attributes;

namespace FS.FinansialServices.DTOs.Currencies
{
    internal class Currency(string name = "BGN") : Model<int>, ICurrency
    {
        [ShortTextValidation(className: nameof(Currency), propertyName: nameof(Name))]
        public string Name { get; set; } = name;
    }
}
