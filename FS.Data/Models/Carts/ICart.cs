using FS.Data.Base;
using FS.Data.Models.Items.CartItems;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Carts
{
    public interface ICart : IModel<int>
    {
        public float TotalPrice { get; }

        public int PartnerId { get; }

        public IPartner Partner { get; set; }

        public IEnumerable<ICartItem> CartItems { get; set; }
    }
}
