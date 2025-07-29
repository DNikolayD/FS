using FS.FinansialServices.DTOs.Base;

namespace FS.FinancialServices.DTOs.Currencies;

public class Currency(string name = "BGN") : Model<int>, ICurrency
{
    [ShortTextLengthValidation(className: nameof(Currency), propertyName: nameof(Name))]
    public string Name { get; set; } = name;
}