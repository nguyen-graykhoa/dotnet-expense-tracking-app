using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpenseApp.Models;

namespace ExpenseApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasData(
                new Models.Account { Id = 1, Depositer = "Stuart", CurrencyType = "Peso", Receiver = "Tony", TransactionType = "deposit", TransactionDescription = "Peso Cash Account", TransactionDate = DateTime.Now, Amount = 400 },
                new Models.Account { Id = 2, Depositer = "", CurrencyType = "Peso", Receiver = "Tony", TransactionType = "withdrawal", TransactionDescription = "Casa 3 - Cleaning", TransactionDate = DateTime.Now, Amount = 400 },
                new Models.Account { Id = 3, Depositer = "", CurrencyType = "Peso", Receiver = "Tony", TransactionType = "withdrawal", TransactionDescription = "Casa 3 - Cleaning", TransactionDate = DateTime.Now, Amount = 400 },
                new Models.Account { Id = 4, Depositer = "Stuart", CurrencyType = "USD", Receiver = "", TransactionType = "deposit", TransactionDescription = "USD Cash Account", TransactionDate = DateTime.Now, Amount = 900 },
                 new Models.Account { Id = 5, Depositer = "", CurrencyType = "USD", Receiver = "Tony", TransactionType = "withdrawal", TransactionDescription = "Monthly Casa Amigo Admin Fee", TransactionDate = DateTime.Now, Amount = 500 }
                );
        }
        public DbSet<ExpenseApp.Models.Account>? Account { get; set; }
    }
}