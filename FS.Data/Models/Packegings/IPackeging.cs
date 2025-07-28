namespace FS.Data.Models.Packegings
{
    public interface IPackeging : IModel<int>
    {
        public decimal Value { get; set; }
    }
}
