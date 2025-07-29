namespace FS.Data.Models.Categories;

/// <summary>
/// Represents a category of a product or products. Categories can be nested.
/// </summary>
public interface ICategory : IModel<int>
{
    /// <summary>
    /// The name of the category.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The description of the category.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The id of an optional parent category in case the category is nested.
    /// </summary>
    public int? ParentId { get; }

    /// <summary>
    /// The parent category in case the category is nested.
    /// </summary>
    public ICategory? Parent { get; set; }


    /// <summary>
    /// The children categories in case the category is nested.
    /// </summary>
    public IEnumerable<ICategory>? Children { get; set; }

    /// <summary>
    /// Indicates if the category is the root category.
    /// </summary>
    public bool IsRoot { get; }

    /// <summary>
    /// Indicates if the category is a leaf category.
    /// </summary>
    public bool IsLeaf { get; }
}