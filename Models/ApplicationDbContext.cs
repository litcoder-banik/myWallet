using Microsoft.EntityFrameworkCore;

namespace myWallet.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserCatagory> UserCatagories { get; set;}
    }
}
