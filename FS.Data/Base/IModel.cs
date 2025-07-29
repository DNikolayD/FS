namespace FS.Data.Base
{
    /// <summary>
    /// Represents a generic model with common properties for tracking creation, modification, and deletion states.
    /// </summary>
    /// <typeparam name="T">The type of the unique identifier for the model.A Guid for classes of higher importance and an int for classes of lower importance.</typeparam>
    public interface IModel<out T>
    {
        /// <summary>
        /// The unique identifier for the model.
        /// </summary>
        public T Id { get; }

        /// <summary>
        /// Indicates if the model was created by means of seeding data or manual input.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// The date and time when the model was created.
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Indicates if the model can be edited by a user
        /// </summary>
        public bool IsEditable { get; set; }

        /// <summary>
        /// Marks if the model has been modified
        /// </summary>
        public bool IsModified { get; set; }

        /// <summary>
        /// The date and time when the model was last modified.
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Indicates if the model can be deleted by a user
        /// </summary>
        public bool IsDeletable { get; set; }

        /// <summary>
        /// Marks if the model has been deleted
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// The date and time when the model was deleted.
        /// </summary>
        public DateTime? DeleteTime { get; set; }
    }
}
