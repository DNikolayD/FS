using FS.Data.Base;

namespace FS.Data.Models.Countries
{
    public class Country(string name = "") : Model<int>, ICountry
    {
        private string _name = name;

        public string Name { get => _name; set => _name = value; }

    }
}
