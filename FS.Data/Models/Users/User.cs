using System.Transactions;
using FS.Data.Models.Balances;
using FS.Data.Models.Carts;
using FS.Data.Models.Categories;
using FS.Data.Models.Countries;
using FS.Data.Models.Currencies;
using FS.Data.Models.FinanceInstitutions;
using FS.Data.Models.FinanceTypes;
using FS.Data.Models.Items;
using FS.Data.Models.Items.CartItems;
using FS.Data.Models.Items.InventoryItems;
using FS.Data.Models.Items.TransactionItems;
using FS.Data.Models.Locations;
using FS.Data.Models.Members;
using FS.Data.Models.Measurements;
using FS.Data.Models.Packagings;
using FS.Data.Models.Partners;
using FS.Data.Models.Payments;
using FS.Data.Models.Roles;
using FS.Data.Models.TransactionTypes;

using Microsoft.AspNetCore.Identity;

namespace FS.Data.Models.Users
{
    public class User : IdentityUser, IModel<string>
    {
        public bool IsDefault { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsEditable { get; set; }

        public bool IsModified { get; set; }

        public DateTime? UpdateTime { get; set; }

        public bool IsDeletable { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeleteTime { get; set; }

        public required IEnumerable<Balance> Balances { get; set; } = [];

        public required IEnumerable<Cart> Carts { get; set; } = [];

        public required IEnumerable<Category> Categories { get; set; } = [];

        public required IEnumerable<Country> Countries { get; set; } = [];

        public required IEnumerable<Currency> Currencies { get; set; } = [];

        public required IEnumerable<FinanceInstitution> FinanceInstitutions { get; set; } = [];

        public required IEnumerable<FinanceType> FinanceTypes { get; set; } = [];

        public required IEnumerable<Item> Items { get; set; } = [];

        public required IEnumerable<CartItem> CartItems { get; set; } = [];

        public required IEnumerable<InventoryItem> InventoryItems { get; set; } = [];

        public required IEnumerable<TransactionItem> TransactionItems { get; set; } = [];

        public required IEnumerable<Location> Locations { get; set; } = [];

        public required IEnumerable<Member> Members { get; set; } = [];

        public required IEnumerable<Measurement> Measurements { get; set; } = [];

        public required IEnumerable<Packaging> Packagings { get; set; } = [];

        public required IEnumerable<Partner> Partners { get; set; } = [];

        public required IEnumerable<Transaction> Transactions { get; set; } = [];

        public required IEnumerable<TransactionType> TransactionTypes { get; set; } = [];

        public IEnumerable<IPayment> Payments { get; set; } = [];

        public string RoleId => Role.Id;

        public required Role Role { get; set; }
    }
}
