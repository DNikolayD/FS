namespace FS.Data.Models.FinanceTypes
{
    public class FinanceType(string name = "") : Model<int>, IFinanceType
    {
        private string _name = name;

        [ShortTextLengthValidation(nameof(FinanceType), nameof(Name))]
        public string Name { get => _name; set => _name = value; }
    }
}
