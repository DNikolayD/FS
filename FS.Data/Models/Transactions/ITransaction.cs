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
    /// <summary>
    /// The date at which the transaction took place. Transaction date is less or equal to date. 
    /// </summary>
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// The total sum to be paid.
    /// </summary>
    public float SumToPay { get; }

    /// <summary>
    /// The id of the partner.
    /// </summary>
    public int PartnerId { get; }

    /// <summary>
    /// The partner.
    /// </summary>
    public IPartner Partner { get; set; }

    /// <summary>
    /// The type of transaction.
    /// </summary>
    public int TransactionTypeId { get; }

    /// <summary>
    /// The type of transaction.
    /// </summary>
    public ITransactionType TransactionType { get; set; }

    /// <summary>
    /// The id of the currency.
    /// </summary>
    public int CurrencyId { get; }

    /// <summary>
    /// The currency in which the transaction took place.
    /// </summary>
    public ICurrency Currency { get; set; }

    /// <summary>
    /// The items in the transaction.
    /// </summary>
    public IEnumerable<ITransactionItem> TransactionItems { get; set; }
}