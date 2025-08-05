using Microsoft.AspNetCore.Identity;

namespace FS.Data.Models.Roles
{
    public class Role : IdentityRole, IModel<string>
    {
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
