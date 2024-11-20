using FS.Data.Base;
using FS.Data.Models.Items.CartItems;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Carts
{
    public class Cart(List<ICartItem> cartItems) : Model<int>, ICart
    {
        private IEnumerable<ICartItem> _cartItems = cartItems;

        public float TotalPrice => _cartItems.Sum(x => x.TotalPrice);

        public int PartnerId => Partner.Id;
        
        public required IPartner Partner { get; set; }

        public required IEnumerable<ICartItem> CartItems { get => _cartItems; set => _cartItems = value; }
    }
}
