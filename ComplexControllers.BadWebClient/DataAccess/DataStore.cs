using ComplexControllers.BadWebClient.Models;
using Microsoft.EntityFrameworkCore;

namespace ComplexControllers.BadWebClient.DataAccess {
    public class DataStore : DbContext {
        public DataStore(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasKey("id");
            modelBuilder.Entity<Article>().HasKey("id");
            
            modelBuilder.Entity<User>()
                .HasData(
                    new User("bob"),
                    new User("james")
                );
        }
    }
}