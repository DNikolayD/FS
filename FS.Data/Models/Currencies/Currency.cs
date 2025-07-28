namespace FS.Data.Models.Currencies
{
    public class Currency(string name = "BGN") : Model<int>, ICurrency
    {
        [ShortTextLengthValidation(nameof(Currency), nameof(Name))]
        public string Name { get; set; } = name;
    }
}
