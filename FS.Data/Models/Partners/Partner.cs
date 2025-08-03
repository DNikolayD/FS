using FS.Data.Models.Locations;
// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength

namespace FS.Data.Models.Partners
{
    public class Partner(ILocation location, string name = "") : Model<int>, IPartner
    {
        [ShortTextLengthValidation(nameof(Partner), nameof(Name))]
        public string Name { get; set; } = name;

        public int LocationId => Location.Id;

        public ILocation Location { get; set; } = location;

        public Partner(string name = "") : this(new Location(), name){
            
        }
    }
}
