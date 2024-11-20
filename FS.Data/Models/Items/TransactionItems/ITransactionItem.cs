using FS.Data.Models.Members;

namespace FS.Data.Models.Items.TransactionItems
{
    public interface ITransactionItem : IItem
    {
        public int Quantity { get; set; }

        public float Price { get; set; }

        public float Total { get; }

        public int MemberId { get; }

        public IMember Member { get; set; }
    }
}
