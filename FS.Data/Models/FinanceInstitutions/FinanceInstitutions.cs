using FS.Data.Base;
using FS.Data.Models.FinanceTypes;

namespace FS.Data.Models.FinanceInstitutions
{
    public class FinanceInstitutions(List<IFinanceType> financeTypes, string name = "") : Model<int>, IFinanceInstitutions
    {
        private string _name = name;

        private List<IFinanceType> _financeTypes = financeTypes ?? [];
        
        public FinanceInstitutions() : this([], "")
        {
            Name = _name;
        }

        public string Name { get => _name; set => _name = value; }
        
        public IEnumerable<IFinanceType> FinanceTypes { get => _financeTypes; set => _financeTypes = value.ToList(); }
    }
}