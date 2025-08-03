namespace FS.Data.Models.Packagings;

/// <summary>
/// Represents the packaging in which an item is bought or used. For example A bottle of water.
/// </summary>
public interface IPackaging : IModel<int>
{
    /// <summary>
    /// The name of the packaging.
    /// </summary>
    public string Name { get; set; }
}
