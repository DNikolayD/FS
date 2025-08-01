using System.Collections;
using FS.Data.Models.Categories;
using FS.Data.Models.Measurements;
using FS.Data.Models.Members;
using FS.Data.Models.Packegings;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Items.TransactionItems
{
    public class TransactionItem(IEnumerable<IPartner> suppliers, IPackaging packaging, ICategory category, IMeasurement measurement, DateTime? expiration, int minimumToBuy, string? name = "", int quantity = 0, float price = 0) : Item(suppliers, packaging, category, measurement, expiration, minimumToBuy, name ?? ""), ITransactionItem
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
