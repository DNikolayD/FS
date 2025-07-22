// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICart.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ICart type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace FS.Data.Models.Carts
{
    using FS.Data.Base;
    using FS.Data.Models.Items.CartItems;
    using FS.Data.Models.Partners;

    /// <summary>
    /// The Cart interface.
    /// </summary>
    public interface ICart : IModel<int>
    {
        /// <summary>
        /// Gets the total price.
        /// </summary>
        public float TotalPrice { get; }

        /// <summary>
        /// Gets the partner id.
        /// </summary>
        public int PartnerId { get; }

        /// <summary>
        /// Gets or sets the partner.
        /// </summary>
        public IPartner Partner { get; set; }

        /// <summary>
        /// Gets or sets the cart items.
        /// </summary>
        public IEnumerable<ICartItem> CartItems { get; set; }
    }
}
