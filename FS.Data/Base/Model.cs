using static FS.Reusable.Instantiator;

namespace FS.Data.Base
{
    public class Model<T>(bool isDefault = false,
        DateTime createTime = default, 
        bool isEditable = false, 
        bool isModified = false, 
        DateTime? updateTime = null, 
        bool isDeletable = false, 
        bool? isDeleted = null, 
        DateTime? deleteTime = null) : IModel<T>
    {
        protected Model(): this(false)
        {
            Id = InstantiateId<T>();
        }

        /// <summary>
        /// The Id of the data object in the database. It is set automatically by the Instanciate
        /// </summary>
        public T Id { get; }

        public bool IsDefault { get; set; } = isDefault;

        public DateTime CreateTime { get; set; } = createTime;

        public bool IsEditable { get; set; } = isEditable;

        public bool IsModified { get; set; } = isModified;

        public DateTime? UpdateTime { get; set; } = updateTime;

        public bool IsDeletable { get; set; } = isDeletable;

        public bool? IsDeleted { get; set; } = isDeleted;

        public DateTime? DeleteTime { get; set; } = deleteTime;
    }
}
