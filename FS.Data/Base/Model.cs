// ReSharper disable MissingXmlDoc
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace FS.Data.Base;

using static Reusable.Instantiator;

public class Model<T>(
    bool isDefault = false,
    DateTime createTime = default, 
    bool isEditable = false, 
    bool isModified = false, 
    DateTime? updateTime = null, 
    bool isDeletable = false, 
    bool? isDeleted = null, 
    DateTime? deleteTime = null) : IModel<T>
{
    protected Model() : this(false)
    {
        Id = InstantiateId<T>();
    }
    public T Id { get; }

    public DateTime CreateTime { get; set; } = createTime;
    public DateTime? DeleteTime { get; set; } = deleteTime;
    public bool IsDefault { get; set; } = isDefault;
    public bool IsDeletable { get; set; } = isDeletable;
    public bool? IsDeleted { get; set; } = isDeleted;
    public bool IsEditable { get; set; } = isEditable;
    public bool IsModified { get; set; } = isModified;
    public DateTime? UpdateTime { get; set; } = updateTime;
}