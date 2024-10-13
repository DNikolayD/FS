using FS.Data.Base;

namespace FS.Data.Models.FinanceTypes
{
    public class FinanceType(string name = "") : Model<int>, IFinanceType
    {
        private string _name = name;

        public string Name { get => _name; set => _name = value; }
    }
}
