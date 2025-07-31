namespace FS.Data.Models.Packegings
{
    public class Packaging(decimal value = 0) : Model<int>, IPackaging
    {
        private decimal _value = value;

        [ValueValidation(nameof(Packaging), nameof(Value))]
        public decimal Value { get => _value; set => _value = value; }
    }
}
