using FS.Data.Base;
using FS.Data.Models.Currencies;
using FS.Data.Models.Items.TransactionItems;
using FS.Data.Models.Partners;
using FS.Data.Models.TransactionTypes;

namespace FS.Data.Models.Transactions
{
    public interface ITransaction : IModel<string>
    {
        public float AmountCurrency { get; set; }

        public float AmountBGN { get; }

        public DateTime TransactionDate { get; set; }

        public float ExchangeRate { get; set; }

        public float SumToPay { get; set; }

        public int PartnerId { get; }

        public IPartner Partner { get; set; }

        public int TransactionTypeId { get; }

        public ITransactionType TransactionType { get; set; }

        public int CurrencyId { get; }

        public ICurrency Currency { get; set; }

        public IEnumerable<ITransactionItem> TransactionItems { get; set; }
    }
}
