namespace FS.Data.Models.Payments;

using Transactions;

/// <summary>
/// The payment for the transaction
/// </summary>
public interface IPayment : IModel<string>
{
    /// <summary>
    /// The amount that is paid
    /// </summary>
    public float Amount { get; }

    /// <summary>
    /// The id of the transaction.
    /// </summary>
    public string TransactionId { get; }

    /// <summary>
    /// The transaction that is getting paid.
    /// </summary>
    public ITransaction Transaction { get; }
}