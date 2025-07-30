namespace FS.Data.Models.FinanceInstitutions;

using FinanceTypes;

/// <summary>
/// Represents a Finance Institution used by the user. For example, a bank or a credit union.
/// </summary>
public interface IFinanceInstitution : IModel<int>
{
    /// <summary>
    /// The name of the Finance Institution.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Finance Types associated with the Finance Institution. For example, bank or credit union.
    /// </summary>
    public IEnumerable<IFinanceType> FinanceTypes  { get; set; }
}