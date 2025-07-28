using FS.Reusable.Attributes.ErrorHandlingAttributes;

namespace FS.Data.Models.Categories;

public class Category(string name = "") : Model<int>, ICategory
{
    public IEnumerable<ICategory>? Children { get; set; }

    public bool IsLeaf => Children == null || !Children.Any();

    public bool IsRoot => Parent == null;

    [ShortTextLengthValidation(nameof(Category), nameof(Name))]
    public string Name { get; set; } = name;

    [LongTextLengthValidation(nameof(Category), nameof(Description))]
    public string Description { get; set; }

    public ICategory? Parent { get; set; }

    public int? ParentId => Parent!.Id;

}