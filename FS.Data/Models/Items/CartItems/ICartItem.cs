namespace FS.Data.Models.Items.CartItems
{
    public interface ICartItem : IItem
    {
        public int Quantity { get; set; }

        public float Price { get; set; }

        public float TotalPrice { get; }
    }
}
