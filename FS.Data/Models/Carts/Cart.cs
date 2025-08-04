// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Carts;

using Items.CartItems;
using Partners;
    
public class Cart(List<ICartItem> cartItems, IPartner partner) : Model<int>, ICart
{
    public float TotalPrice => CartItems.Sum(x => x.TotalPrice);

    public int PartnerId => Partner.Id;

    public required IPartner Partner { get; set; } = partner;

    public required IEnumerable<ICartItem> CartItems { get; set; } = cartItems;

    public Cart(IPartner partner) : this([], partner){}

    public Cart(List<ICartItem> cartItems) : this(cartItems, Instantiate<Partner>()){}

    public Cart() : this([], Instantiate<Partner>()){}
}