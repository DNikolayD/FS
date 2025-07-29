// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Carts;

using Items.CartItems;
using Partners;
    
public class Cart(List<ICartItem> cartItems) : Model<int>, ICart
{
    public float TotalPrice => CartItems.Sum(x => x.TotalPrice);

    public int PartnerId => Partner.Id;
    
    public required IPartner Partner { get; set; }

    public required IEnumerable<ICartItem> CartItems { get; set; } = cartItems;
}