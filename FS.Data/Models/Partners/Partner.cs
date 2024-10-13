using FS.Data.Base;
using FS.Data.Models.Locations;

namespace FS.Data.Models.Partners
{
    public class Partner(string name, ILocation location) : Model<int>, IPartner
    {
        private string _name = name;

        private ILocation _location = location;

        public string Name { get => _name; set => _name = value; }

        public int LocationId => _location.Id;

        public ILocation Location { get => _location; set => _location = value; }
    }
}
