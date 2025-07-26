// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FS.Data.Base
{

    /// <summary>
    /// The Model interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IModel<T>
    {
        public T Id { get; set; }

        public bool IsDefault { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsEditable { get; set; }

        public bool IsModified { get; set; }

        public DateTime? UpdateTime { get; set; }

        public bool IsDeletable { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeleteTime { get; set; }

    }
}
