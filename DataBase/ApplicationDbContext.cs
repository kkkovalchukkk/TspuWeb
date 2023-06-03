
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<DbUser> Users { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<UserPurchase> UserPurchases { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public"); 
            modelBuilder.Entity<DbUser>
                (b => {
                    b.ToTable("users");
                    b.HasKey(u => u.Id);
                    b.Property(user => user.Id).HasColumnName("id"); 
                    b.Property(user => user.Login).HasColumnName("login"); 
                    b.Property(user => user.UserName).HasColumnName("name"); 
                    b.Property(user => user.Isdeleted).HasColumnName("isdeleted");
                });
            modelBuilder.Entity<Product>
                (b => {
                    b.ToTable("productss"); 
                    b.HasKey(u => u.Id);
                    b.Property(product => product.Id).HasColumnName("id"); 
                    b.Property(product => product.Name).HasColumnName("name"); 
                    b.Property(product => product.Description).HasColumnName("description"); 
                    b.Property(product => product.Price).HasColumnName("price"); 
                    b.Property(product => product.Isdeleted).HasColumnName("isdeleted"); 
                });
            modelBuilder.Entity<UserPurchase>
            (b => {
                b.ToTable("userpurchase");
                b.HasKey(u => u.Id);
                b.Property(userpurchase => userpurchase.Id).HasColumnName("id"); 
                b.Property(userpurchase => userpurchase.UserId).HasColumnName("userid");
                b.Property(userpurchase => userpurchase.ProductId).HasColumnName("productid");
                b.Property(userpurchase => userpurchase.Price).HasColumnName("price");
              
            });
        }
    }
}
