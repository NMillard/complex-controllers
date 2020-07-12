using ComplexControllers.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComplexControllers.DataLayer {
    public class DataStore : DbContext {
        public DataStore(DbContextOptions options) : base(options) {
        }

        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasKey("id");
            modelBuilder.Entity<Article>().HasKey("id");

            modelBuilder.Entity<User>().HasData(new User("bobbyG"), new User("Flemming"));
        }
    }
}