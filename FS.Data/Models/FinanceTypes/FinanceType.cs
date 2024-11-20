using FS.Data.Attributes;
using FS.Data.Base;

namespace FS.Data.Models.FinanceTypes
{
    public class FinanceType(string name = "") : Model<int>, IFinanceType
    {
        private string _name = name;

        [ShortTextValidation(nameof(FinanceType), nameof(Name))]
        public string Name { get => _name; set => _name = value; }
    }
}
