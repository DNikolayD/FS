using FS.Data.Base;
using FS.Data.Models.Countries;

namespace FS.Data.Models.Locations
{
    public class Location(ICountry country, string address = "") : Model<int>, ILocation
    {
        private string _address = address;

        private ICountry _country = country;

        public Location() : this(country: new Country(),address: "")
        {
            _country ??= new Country();
        }

        public string Address { get => _address; set => _address = value; }
        
        public int CountryId { get => country == null ? 0 : country.Id; }
        
        public ICountry Country { get => _country; set => _country = value; }
    }
}
