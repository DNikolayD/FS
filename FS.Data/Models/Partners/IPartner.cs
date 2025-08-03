using FS.Data.Models.Locations;

namespace FS.Data.Models.Partners;

public interface IPartner : IModel<int>
{
    public string Name { get; set; }

    public int LocationId { get; }

    public ILocation Location { get; set; }
}