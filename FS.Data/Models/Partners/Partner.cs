using FS.Data.Models.Locations;

namespace FS.Data.Models.Partners
{
    public class Partner(ILocation location, string name = "") : Model<int>, IPartner
    {
        private string _name = name;

        [ShortTextLengthValidation(nameof(Partner), nameof(Name))]
        public string Name { get => _name; set => _name = value; }

        public int LocationId => Location.Id;

        public ILocation Location { get; set; }
    }
}
