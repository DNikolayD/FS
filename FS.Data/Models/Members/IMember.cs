namespace FS.Data.Models.Members;

/// <summary>
/// The member of a household in case of multi-member household.
/// </summary>
public interface IMember: IModel<int>
{
    /// <summary>
    /// The name of the family member.
    /// </summary>
    public string Name { get; set; }
}