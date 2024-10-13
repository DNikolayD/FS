using static FS.Data.Instanciator;

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
        private bool _isDefault = isDefault;

        private DateTime _createTime = createTime;

        private bool _isEditable = isEditable;

        private bool _isModified = isModified;

        private DateTime? _updateTime = updateTime;

        private bool _isDeletable = isDeletable;

        private bool? _isDeleted = isDeleted;

        private DateTime? _deleteTime = deleteTime;

        public Model(): this(false, default, false, false, null, false, null, null)
            { 
            this.Id = InstantiateId<T>();
            }

        public T Id { get; set; }

        public bool IsDefault { get => _isDefault; set => _isDefault = value; }

        public DateTime CreateTime { get => _createTime; set => _createTime = value; }
        
        public bool IsEditable { get => _isEditable; set => _isEditable = value; }
        
        public bool IsModified { get => _isModified; set => _isModified = value; }
        
        public DateTime? UpdateTime { get => _updateTime; set => _updateTime = value; }
        
        public bool IsDeletable { get => _isDeletable; set => _isDeletable = value; }
        
        public bool? IsDeleted { get => _isDeleted; set => _isDeleted = value; }
        
        public DateTime? DeleteTime { get => _deleteTime; set => _deleteTime = value; }
    }
}
