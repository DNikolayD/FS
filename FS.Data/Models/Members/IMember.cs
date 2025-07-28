namespace FS.Data.Models.Members
{
    public interface IMember: IModel<int>
    {
        public string Name { get; set; }
    }
}
