using static FS.Reusable.Instanciator;

namespace FS.Data.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="isDefault"></param>
    /// <param name="createTime"></param>
    /// <param name="isEditable"></param>
    /// <param name="isModified"></param>
    /// <param name="updateTime"></param>
    /// <param name="isDeletable"></param>
    /// <param name="isDeleted"></param>
    /// <param name="deleteTime"></param>
    /// <typeparam name="T"></typeparam>
    public class Model<T>(bool isDefault = false,
        DateTime createTime = default, 
        bool isEditable = false, 
        bool isModified = false, 
        DateTime? updateTime = null, 
        bool isDeletable = false, 
        bool? isDeleted = null, 
        DateTime? deleteTime = null) : IModel<T>
    {
        /// <summary>
        /// 
        /// </summary>
        protected Model(): this(false)
            { 
            this.Id = InstantiateId<T>();
            }

        /// <summary>
        /// 
        /// </summary>
        public required T Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsDefault { get; set; } = isDefault;

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; } = createTime;

        /// <summary>
        /// 
        /// </summary>
        public bool IsEditable { get; set; } = isEditable;

        /// <summary>
        /// 
        /// </summary>
        public bool IsModified { get; set; } = isModified;

        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime { get; set; } = updateTime;

        /// <summary>
        /// 
        /// </summary>
        public bool IsDeletable { get; set; } = isDeletable;

        /// <summary>
        /// 
        /// </summary>
        public bool? IsDeleted { get; set; } = isDeleted;

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DeleteTime { get; set; } = deleteTime;
    }
}
