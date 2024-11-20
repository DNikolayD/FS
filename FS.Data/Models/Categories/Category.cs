
using FS.Data.Attributes;
using FS.Data.Base;

namespace FS.Data.Models.Categories
{
    public class Category(string name = "") : Model<int>, ICategory
    {
        private string _name = name;

        [ShortTextValidation(nameof(Category), nameof(Name))]
        public string Name { get => _name; set => _name = value; }
        
        public int? ParentId => Parent!.Id;
        
        public ICategory? Parent { get; set; }
        
        public IEnumerable<ICategory>? Children { get; set; }
        
        public bool IsRoot { get => Parent == null; set => SetIsRoot(); }
        
        public bool IsLeaf { get => Children == null || !Children.Any(); set => SetIsLeaf(); }

        private void SetIsRoot() => IsRoot = Parent == null;

        private void SetIsLeaf() => IsLeaf = Children == null || !Children.Any();
    }
}
