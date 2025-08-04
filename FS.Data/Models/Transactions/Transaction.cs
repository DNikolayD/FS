// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Transactions;

using Currencies;
using Items.TransactionItems;
using Partners;
using TransactionTypes;


public class Transaction(IPartner partner, ITransactionType transactionType, ICurrency currency, DateTime transactionDate = default) : Model<string>, ITransaction
{
    public DateTime TransactionDate { get; set; } = transactionDate > DateTime.Now ? DateTime.Now : transactionDate;

    public float SumToPay => TransactionItems.Sum(x => x.TotalPrice);

    public int PartnerId => Partner.Id;

    public required IPartner Partner { get; set; } = partner;

    public int TransactionTypeId => TransactionType.Id;

    public required ITransactionType TransactionType { get; set; } = transactionType;

    public int CurrencyId => Currency.Id;

    public required ICurrency Currency { get; set; } = currency;

    public IEnumerable<ITransactionItem> TransactionItems { get; set; } = [];

    public Transaction(IPartner partner, ITransactionType transactionType, DateTime transactionDate = default) : this(partner, transactionType, new Currency(), transactionDate){}

    public Transaction(IPartner partner, ICurrency currency, DateTime transactionDate = default) : this(partner, new TransactionType(), currency, transactionDate){}

    public Transaction(ICurrency currency, ITransactionType transactionType, DateTime transactionDate = default) : this(new Partner(), transactionType, currency, transactionDate){}

    public Transaction(ITransactionType transactionType, DateTime transactionDate = default) : this(new Partner(), transactionType, new Currency(), transactionDate){}

    public Transaction(IPartner partner, DateTime transactionDate = default) : this(partner, new TransactionType(), new Currency(), transactionDate){}

    public Transaction(ICurrency currency, DateTime transactionDate = default) : this(new Partner(), new TransactionType(), currency, transactionDate){}

    public Transaction(DateTime transactionDate = default) : this(new Partner(), new TransactionType(), new Currency(), transactionDate){}
}