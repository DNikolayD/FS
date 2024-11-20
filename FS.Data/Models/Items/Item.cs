using FS.Data.Attributes;
using FS.Data.Base;
using FS.Data.Models.Categories;
using FS.Data.Models.Messurements;
using FS.Data.Models.Packegings;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Items
{
    public class Item(string name = "") : Model<string>, IItem
    {
        private string _name = name;

        [ShortTextValidation(nameof(Item), nameof(Name))]
        public string Name { get => _name; set => _name = value; }

        public float? MinimumToBuy { get; set; }

        public DateTime? Expiration { get; set; }

        public int MessuremantId => Messuremant.Id;

        public required IMessurement Messuremant { get; set; }

        public int? PackagingId => Packaging?.Id;

        public IPackeging? Packaging { get; set; }

        public int CategoryId => Category.Id;

        public required ICategory Category { get; set; }

        public required IEnumerable<IPartner> Suppliers { get; set; }
    }
}
