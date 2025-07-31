namespace FS.Data.Models.Packegings
{
    public interface IPackaging : IModel<int>
    {
        public decimal Value { get; set; }
    }
}
