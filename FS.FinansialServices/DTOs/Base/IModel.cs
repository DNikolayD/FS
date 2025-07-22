namespace FS.FinansialServices.DTOs.Base
{
    public interface IModel<T>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public T Id { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the is editable.
        /// </summary>
        public bool IsEditable { get; set; }

        /// <summary>
        /// Gets or sets the is modified.
        /// </summary>
        public bool IsModified { get; set; }

        /// <summary>
        /// Gets or sets the update time.
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the is deletable.
        /// </summary>
        public bool IsDeletable { get; set; }

        /// <summary>
        /// Gets or sets the is deleted.
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the delete time.
        /// </summary>
        public DateTime? DeleteTime { get; set; }

    }
}
