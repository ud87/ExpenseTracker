using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    public class ApplicationDbContext: DbContext //inherits the built in DbContext class from EF core, gives class all the core database operations, servers as a bridge between C# code and db
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // Constructor that takes DbContextOptions and passes it to the base class constructor
        {
            
        }

        //creates a table named Transactions and will have all of our data in Transaction.cs model
        public DbSet<Transaction> Transactions { get; set; } // Represents the collection of transactions in the database
        public DbSet<Category> Categories { get; set; } // Represents the collection of categories in the database
    }
}
