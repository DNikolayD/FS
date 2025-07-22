using FS.FinansialServices.DTOs.Base;

namespace FS.FinansialServices.DTOs.Currencies
{
    public interface ICurrency : IModel<int>
    {
        public string Name { get; set; }
    }
}
