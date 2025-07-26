using FS.Data.Base;
using FS.Data.Models.Countries;
using FS.Reusable.Attributes.ErrorHandlingAtrtibutes;

namespace FS.Data.Models.Locations
{
    public class Location(string address = "") : Model<int>, ILocation
    {
        private string _address = address;

        [LengthValidation(nameof(Location), nameof(Address))]
        public string Address { get => _address; set => _address = value; }
        
        public int CountryId => Country.Id;
        
        public required ICountry Country { get; set; }
    }
}
