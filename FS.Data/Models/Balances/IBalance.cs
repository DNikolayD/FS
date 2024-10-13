using FS.Data.Base;

namespace FS.Data.Models.Balances
{
    public interface IBalance : IModel<int>
    {
        public string Currency { get; set; }

        public decimal Value { get; set; }
    }
}
