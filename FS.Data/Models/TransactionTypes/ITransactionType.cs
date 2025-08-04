namespace FS.Data.Models.TransactionTypes;

/// <summary>
/// The type of  transaction.
/// </summary>
public interface ITransactionType : IModel<int>
{
    /// <summary>
    /// The name of the type.
    /// </summary>
    public string Name { get; set; }
}