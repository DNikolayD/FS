using FS.Reusable.Attributes;
using FS.Data.Base;

namespace FS.Data.Models.Categories
{
    public class Category(string name = "") : Model<int>, ICategory
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ICategory>? Children { get; set; }

        public bool IsLeaf
        {
            get => Children == null || !Children.Any();
            set => SetIsLeaf();
        }

        public bool IsRoot
        { 
            get => Parent == null; 
            set => SetIsRoot();
        }

        /// <summary>
        /// 
        /// </summary>
        [ShortTextValidation(nameof(Category), nameof(Name))]
        public string Name { get; set; } = name;

        /// <summary>
        /// 
        /// </summary>
        public ICategory? Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? ParentId => this.Parent!.Id;

        private void SetIsRoot() => IsRoot = Parent == null;

        private void SetIsLeaf() => IsLeaf = !(Children == null && Children.Any());
    }
}
