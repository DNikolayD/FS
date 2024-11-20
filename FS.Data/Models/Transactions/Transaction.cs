using FS.Data.Attributes;
using FS.Data.Base;
using FS.Data.Models.Currencies;
using FS.Data.Models.Items.TransactionItems;
using FS.Data.Models.Partners;
using FS.Data.Models.TransactionTypes;

namespace FS.Data.Models.Transactions
{
    public class Transaction(float amountCurrency = 0, DateTime transactionDate = default, float exchangeRate = 1, float sumToPay = 0) : Model<string>, ITransaction
    {
        private float _amountCurrency = amountCurrency;

        private DateTime _transactionDate = transactionDate == default ? DateTime.Now : transactionDate;

        private float _exchangeRate = exchangeRate;

        private float _sumToPay = sumToPay;

        [ValueValidation(nameof(Transaction), nameof(AmountCurrency))]
        public float AmountCurrency { get => _amountCurrency; set => _amountCurrency = value; }

        public float AmountBGN  => _amountCurrency * _exchangeRate;

        public DateTime TransactionDate { get => _transactionDate; set => _transactionDate = value; }

        [ValueValidation(nameof(Transaction), nameof(ExchangeRate))]
        public float ExchangeRate { get => _exchangeRate; set => _exchangeRate = value; }

        [ValueValidation(nameof(Transaction), nameof(SumToPay))]
        public float SumToPay { get => _sumToPay; set => _sumToPay = value; }

        public int PartnerId => Partner.Id;

        public required IPartner Partner { get; set; }

        public int TransactionTypeId => TransactionType.Id;

        public required ITransactionType TransactionType { get; set; }

        public int CurrencyId => Currency.Id;

        public required ICurrency Currency { get; set; }

        public required IEnumerable<ITransactionItem> TransactionItems { get; set; }
    }
}
