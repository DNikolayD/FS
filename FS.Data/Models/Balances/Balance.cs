using FS.Data.Base;

namespace FS.Data.Models.Balances
{
    public class Balance(string currency = "BG", decimal value = 0) : Model<int>, IBalance
    {
        private string _currency = currency;

        private decimal _value = value;

        public string Currency { get => _currency; set => _currency = value; }
        public decimal Value { get => _value; set => _value = value; }
    }
}
