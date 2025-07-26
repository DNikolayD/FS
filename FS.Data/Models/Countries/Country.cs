using FS.Reusable.Attributes;
using FS.Data.Base;
using FS.Reusable.Attributes.ErrorHandlingAtrtibutes;

namespace FS.Data.Models.Countries
{
    public class Country(string name = "") : Model<int>, ICountry
    {
        private string _name = name;

        [LengthValidation(nameof(Country), nameof(Name))]
        public string Name { get => _name; set => _name = value; }

    }
}
