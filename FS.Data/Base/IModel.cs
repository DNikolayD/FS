namespace FS.Data.Base
{
    public interface IModel<out T>
    {
        public T Id { get; }

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
