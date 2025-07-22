using FS.Reusable.Attributes;
using FS.Data.Base;
using FS.Data.Models.Locations;

namespace FS.Data.Models.Partners
{
    public class Partner(string name = "") : Model<int>, IPartner
    {
        private string _name = name;

        [ShortTextValidation(nameof(Partner), nameof(Name))]
        public string Name { get => _name; set => _name = value; }

        public int LocationId => Location.Id;

        public required ILocation Location { get; set; }
    }
}
