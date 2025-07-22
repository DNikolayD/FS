using FS.Data.Base;
using FS.Data.Models.Items.CartItems;
using FS.Data.Models.Partners;

namespace FS.Data.Models.Carts
{
    public class Cart(List<ICartItem> cartItems) : Model<int>, ICart
    {
        /// <summary>
        /// 
        /// </summary>
        public float TotalPrice => this.CartItems.Sum(x => x.TotalPrice);

        /// <summary>
        /// 
        /// </summary>
        public int PartnerId => this.Partner.Id;
        
        /// <summary>
        /// 
        /// </summary>
        public required IPartner Partner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public required IEnumerable<ICartItem> CartItems { get; set; } = cartItems;
    }
}
