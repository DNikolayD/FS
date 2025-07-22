using FS.Reusable.Attributes;
using FS.Data.Base;
using FS.Data.Models.Countries;

namespace FS.Data.Models.Locations
{
    public class Location(string address = "") : Model<int>, ILocation
    {
        private string _address = address;

        [LongTextValidation(nameof(Location), nameof(Address))]
        public string Address { get => _address; set => _address = value; }
        
        public int CountryId => Country.Id;
        
        public required ICountry Country { get; set; }
    }
}
