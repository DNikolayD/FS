using FS.Reusable.Attributes;
using FS.Data.Base;

namespace FS.Data.Models.Currencies
{
    public class Currency(string name = "BGN") : Model<int>, ICurrency
    {
        [ShortTextValidation(nameof(Currency), nameof(Name))]
        public string Name { get; set; } = name;
    }
}
