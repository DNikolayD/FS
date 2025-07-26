using FS.FinansialServices.DTOs.Base;

namespace FS.FinancialServices.DTOs.Currencies
{
    public interface ICurrency : IModel<int>
    {
        public string Name { get; set; }
    }
}
