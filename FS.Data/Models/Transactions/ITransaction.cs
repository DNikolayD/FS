namespace FS.Data.Models.Transactions;

using Currencies;
using Items.TransactionItems;
using Partners;
using TransactionTypes;

/// <summary>
/// Represents a monetary transaction between the user and a partner. Transactions between members are not counted because they are in-house transactions. 
/// </summary>
public interface ITransaction : IModel<string>
{

    public float AmountCurrency { get; set; }

    public DateTime TransactionDate { get; set; }

    public float SumToPay { get; set; }

    public int PartnerId { get; }

    public IPartner Partner { get; set; }

    public int TransactionTypeId { get; }

    public ITransactionType TransactionType { get; set; }

    public int CurrencyId { get; }

    public ICurrency Currency { get; set; }

    public IEnumerable<ITransactionItem> TransactionItems { get; set; }
}