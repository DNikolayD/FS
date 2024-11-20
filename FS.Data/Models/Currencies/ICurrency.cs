using FS.Data.Base;

namespace FS.Data.Models.Currencies
{
    public interface ICurrency : IModel<int>
    {
        public string Name { get; set; }
    }
}
