using FS.Data.Base;
using FS.Data.Models.FinanceTypes;

namespace FS.Data.Models.FinanceInstitutions
{
    public interface IFinanceInstitutions : IModel<int>
    {
        public string Name { get; set; }

        public IEnumerable<IFinanceType> FinanceTypes  { get; set; }
    }
}
