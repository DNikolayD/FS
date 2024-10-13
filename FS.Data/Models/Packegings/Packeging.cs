using FS.Data.Base;

namespace FS.Data.Models.Packegings
{
    public class Packeging(decimal value = 0) : Model<int>, IPackeging
    {
        private decimal _value = value;

        public decimal Value { get => _value; set => _value = value; }
    }
}
