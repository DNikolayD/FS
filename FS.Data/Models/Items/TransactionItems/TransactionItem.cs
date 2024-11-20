using FS.Data.Attributes;
using FS.Data.Models.Members;

namespace FS.Data.Models.Items.TransactionItems
{
    public class TransactionItem(int quantity = 0, float price = 0) : Item, ITransactionItem
    {
        private int _quantity = quantity;

        private float _price = price;

        [ValueValidation(nameof(TransactionItem), nameof(Quantity))]
        public int Quantity { get => _quantity; set => _quantity = value; }

        [ValueValidation(nameof(TransactionItem), nameof(Price))]
        public float Price { get => _price; set => _price = value; }

        public float Total  => _price * _quantity;

        public int MemberId => Member.Id;

        public required IMember Member { get; set; }
    }
}
