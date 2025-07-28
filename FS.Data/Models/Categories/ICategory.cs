namespace FS.Data.Models.Categories
{
    public interface ICategory : IModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; }

        public ICategory? Parent { get; set; }

        public IEnumerable<ICategory>? Children { get; set; }

        public bool IsRoot { get; }

        public bool IsLeaf { get; }
    }
}
