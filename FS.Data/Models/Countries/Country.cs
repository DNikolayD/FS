namespace FS.Data.Models.Countries
{
    public class Country(string name = "") : Model<int>, ICountry
    {
        private string _name = name;

        [ShortTextLengthValidation(nameof(Country), nameof(Name))]
        public string Name { get => _name; set => _name = value; }

    }
}
