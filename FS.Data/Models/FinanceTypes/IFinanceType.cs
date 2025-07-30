namespace FS.Data.Models.FinanceTypes;


/// <summary>
/// Represents a FinanceType like Cash, Card, Bank
/// </summary>
public interface IFinanceType : IModel<int>
{
    /// <summary>
    /// Name of the FinanceType
    /// </summary>
    public string Name { get; set; }
}