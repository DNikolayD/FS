using FS.Data.Attributes;
using FS.Data.Base;

namespace FS.Data.Models.Currencies
{
    public class Currency(string name = "BGN") : Model<int>, ICurrency
    {
        private string _name = name;

        [ShortTextValidation(nameof(Currency), nameof(Name))]
        public string Name { get => _name; set => _name = value; }
    }
}
