
using FS.Data.Base;

using Microsoft.AspNetCore.Identity;

namespace FS.Data.Models.Users
{
    public class User : IdentityUser, IModel<string>
    {
        private bool _isDefault;

        private DateTime _createTime;

        private bool _isEditable;

        private bool _isModified;

        private DateTime? _updateTime;

        private bool _isDeletable;

        private bool? _isDeleted;

        private DateTime? _deleteTime;

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
