using FS.Data.Models.Categories;
using FS.Data.Models.Meassurements;
using FS.Data.Models.Measurements;
using FS.Data.Models.Packegings;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Items
{
    public interface IItem : IModel<string>
    {
        public string Name { get; set; }

        public float? MinimumToBuy { get; set; }

        public DateTime? Expiration { get; set; }

        public int MeasurementId { get; }

        public IMeasurement Measurement { get; set; }

        public int? PackagingId { get; }

        public IPackaging? Packaging { get; set; }

        public int CategoryId { get; }

        public ICategory Category { get; set; }

        public IEnumerable<IPartner> Suppliers { get; set; }
    }
}
