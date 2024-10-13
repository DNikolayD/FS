using FS.Data.Base;

namespace FS.Data.Models.FinanceTypes
{
    public interface IFinanceType : IModel<int>
    {
        public string Name { get; set; }
    }
}
