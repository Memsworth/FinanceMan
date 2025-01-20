using FinanceMan.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceMan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public string DbPath { get; set; }

        public ApplicationDbContext()
        {
            var docsFilePath = Environment.SpecialFolder.MyDocuments;
            DbPath = Path.Join(Environment.GetFolderPath(docsFilePath), "FinanceMan.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
