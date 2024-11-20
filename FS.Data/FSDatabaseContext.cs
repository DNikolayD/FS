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
using FS.Data.Models.Messurements;
using FS.Data.Models.Packegings;
using FS.Data.Models.Partners;
using FS.Data.Models.Roles;
using FS.Data.Models.Transactions;
using FS.Data.Models.TransactionTypes;
using FS.Data.Models.Users;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FS.Data;

public class FSDatabaseContext() : IdentityDbContext<User, Role, string>
{
     
    public required DbSet<Balance> Balances { get; set; } 

    public required DbSet<Cart> Carts { get; set; }

    public required DbSet<Category> Categories { get; set; }

    public required DbSet<Country> Countries { get; set; }

    public required DbSet<Currency> Currencies { get; set; }

    public required DbSet<FinanceInstitution> FinanceInstitutions { get; set; }

    public required DbSet<FinanceType> FinanceTypes { get; set; }

    public required DbSet<Item> Items { get; set; }

    public required DbSet<CartItem> CartItems { get; set; }

    public required DbSet<InventoryItem> InventoryItems { get; set; }

    public required DbSet<TransactionItem> TransactionItems { get; set; }

    public required DbSet<Location> Locations { get; set; }

    public required DbSet<Member> Members { get; set; }

    public required DbSet<Messurement> Messurements { get; set; }

    public required DbSet<Packeging> Packegings { get; set; }

    public required DbSet<Partner> Partners { get; set; }

    public required DbSet<Transaction> Transactions { get; set; }

    public required DbSet<TransactionType> TransactionTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}
