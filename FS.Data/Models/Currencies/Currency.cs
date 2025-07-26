using FS.Reusable.Attributes;
using FS.Data.Base;
using FS.Reusable.Attributes.ErrorHandlingAtrtibutes;

namespace FS.Data.Models.Currencies
{
    public class Currency(string name = "BGN") : Model<int>, ICurrency
    {
        [LengthValidation(nameof(Currency), nameof(Name))]
        public string Name { get; set; } = name;
    }
}
