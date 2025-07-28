using FS.Data.Models.Countries;

namespace FS.Data.Models.Locations
{
    public interface ILocation: IModel<int>
    {
        public string Address { get; set; }

        public int CountryId { get; }

        public ICountry Country { get; set; }
    }
}
