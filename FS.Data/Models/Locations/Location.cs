using FS.Data.Models.Countries;
using FS.Reusable.Attributes.ErrorHandlingAttributes;

namespace FS.Data.Models.Locations
{
    public class Location(ICountry country, string address = "") : Model<int>, ILocation
    {
        private string _address = address;

        [LongTextLengthValidation(nameof(Location), nameof(Address))]
        public string Address { get => _address; set => _address = value; }
        
        public int CountryId => Country.Id;

        public ICountry Country { get; set; } = country;
    }
}
