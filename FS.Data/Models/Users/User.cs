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
using FS.Data.Models.Meassurements;
using FS.Data.Models.Packegings;
using FS.Data.Models.Partners;
using FS.Data.Models.Roles;
using FS.Data.Models.TransactionTypes;

using Microsoft.AspNetCore.Identity;

namespace FS.Data.Models.Users
{
    public class User : IdentityUser, IModel<string>
    {
        private bool _isDefault;

        private DateTime _createTime;

        private bool _isEditable;

        private bool _isModified;

        private DateTime? _updateTime;

        private bool _isDeletable;

        private bool? _isDeleted;

        private DateTime? _deleteTime;

        private IEnumerable<Balance> _balances = [];

        private IEnumerable<Cart> _carts =[];

        private IEnumerable<Category> _categories = [];

        private IEnumerable<Country> _countries = [];

        private IEnumerable<Currency> _currencies = [];

        private IEnumerable<FinanceInstitution> _financeInstitutions = [];

        private IEnumerable<FinanceType> _financeTypes = [];

        private IEnumerable<Item> _items = [];

        private IEnumerable<CartItem> _cartItems = [];

        private IEnumerable<InventoryItem> _inventoryItems = [];

        private IEnumerable<TransactionItem> _transactionItems = [];

        private IEnumerable<Location> _locations = [];

        private IEnumerable<Member> _members = [];

        private IEnumerable<Measurement> _measurements = [];

        private IEnumerable<Packeging> _packagings = [];

        private IEnumerable<Partner> _partners = [];

        private IEnumerable<Transaction> _transactions = [];

        private IEnumerable<TransactionType> _transactionTypes = [];

        public bool IsDefault { get => _isDefault; set => _isDefault = value; }

        public DateTime CreateTime { get => _createTime; set => _createTime = value; }

        public bool IsEditable { get => _isEditable; set => _isEditable = value; }

        public bool IsModified { get => _isModified; set => _isModified = value; }

        public DateTime? UpdateTime { get => _updateTime; set => _updateTime = value; }

        public bool IsDeletable { get => _isDeletable; set => _isDeletable = value; }

        public bool? IsDeleted { get => _isDeleted; set => _isDeleted = value; }

        public DateTime? DeleteTime { get => _deleteTime; set => _deleteTime = value; }

        public required IEnumerable<Balance> Balances { get => _balances; set => _balances = value; }
               
        public required IEnumerable<Cart> Carts { get => _carts; set => _carts = value; }
               
        public required IEnumerable<Category> Categories { get => _categories; set => _categories = value; }
               
        public required IEnumerable<Country> Countries { get => _countries; set => _countries = value; }
               
        public required IEnumerable<Currency> Currencies { get => _currencies; set => _currencies = value; }
               
        public required IEnumerable<FinanceInstitution> FinanceInstitutions { get => _financeInstitutions; set => _financeInstitutions = value; }
               
        public required IEnumerable<FinanceType> FinanceTypes { get => _financeTypes; set => _financeTypes = value; }
               
        public required IEnumerable<Item> Items { get => _items; set => _items = value; }
               
        public required IEnumerable<CartItem> CartItems { get => _cartItems; set => _cartItems = value; }
               
        public required IEnumerable<InventoryItem> InventoryItems { get => _inventoryItems; set => _inventoryItems = value; }
               
        public required IEnumerable<TransactionItem> TransactionItems { get => _transactionItems; set => _transactionItems = value; }
               
        public required IEnumerable<Location> Locations { get => _locations; set => _locations = value; }
               
        public required IEnumerable<Member> Members { get => _members; set => _members = value; }
               
        public required IEnumerable<Measurement> Measurements { get => _measurements; set => _measurements = value; }
               
        public required IEnumerable<Packeging> Packagings { get => _packagings; set => _packagings = value; }
               
        public required IEnumerable<Partner> Partners { get => _partners; set => _partners = value; }
               
        public required IEnumerable<Transaction> Transactions { get => _transactions; set => _transactions = value; }
               
        public required IEnumerable<TransactionType> TransactionTypes { get => _transactionTypes; set => _transactionTypes = value; }
               
        public string RoleId => Role.Id;

        public required Role Role { get; set; }
    }
}
