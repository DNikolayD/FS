using static FS.Reusable.Instantiator;

namespace FS.FinansialServices.DTOs.Base
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
            this.Id = InstantiateId<T>();
        }

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
