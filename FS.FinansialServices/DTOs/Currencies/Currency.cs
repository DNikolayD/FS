using FS.FinansialServices.DTOs.Base;
using FS.Reusable.Attributes.ErrorHandlingAtrtibutes;

namespace FS.FinancialServices.DTOs.Currencies
{
    internal class Currency(string name = "BGN") : Model<int>, ICurrency
    {
        [LengthValidation(className: nameof(Currency), propertyName: nameof(Name))]
        public string Name { get; set; } = name;
    }
}
