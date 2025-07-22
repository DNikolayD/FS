// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICategory.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ICategory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace FS.Data.Models.Categories
{
    using FS.Data.Base;

    /// <summary>
    /// The Category interface.
    /// </summary>
    public interface ICategory : IModel<int>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the parent id.
        /// </summary>
        public int? ParentId { get; }

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        public ICategory? Parent { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        public IEnumerable<ICategory>? Children { get; set; }

        /// <summary>
        /// Gets or sets the is root.
        /// </summary>
        public bool IsRoot { get; set; }

        /// <summary>
        /// Gets or sets the is leaf.
        /// </summary>
        public bool IsLeaf { get; set; }
    }
}
