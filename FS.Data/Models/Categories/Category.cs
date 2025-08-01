// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.Categories;


public class Category(IEnumerable<ICategory> children, ICategory parent, string name = "", string description = "") : Model<int>, ICategory
{
    public IEnumerable<ICategory>? Children { get; set; } = children;

    public bool IsLeaf => Children == null || !Children.Any();

    public bool IsRoot => Parent == null;

    [ShortTextLengthValidation(nameof(Category), nameof(Name))]
    public string Name { get; set; } = name;

    [LongTextLengthValidation(nameof(Category), nameof(Description))]
    public string Description { get; set; } = description;

    public ICategory? Parent { get; set; } = parent;

    public int? ParentId => Parent!.Id;

}