using FS.Reusable.Attributes.ErrorHandlingAtrtibutes;

namespace FS.Data.Models.Items.CartItems
{
    public class CartItem(int quantity = 1, float price = 0) : Item, ICartItem
    {
        private int _quantity = quantity;

        private float _price = price;

        [ValueValidation(nameof(CartItem), nameof(Quantity))]
        public int Quantity { get => _quantity; set => _quantity = value; }

        [ValueValidation(nameof(CartItem), nameof(Price))]
        public float Price { get => _price; set => _price = value; }

        public float TotalPrice => _quantity * _price;
    }
}
