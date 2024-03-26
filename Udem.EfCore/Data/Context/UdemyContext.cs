using Microsoft.EntityFrameworkCore;
using Udem.EfCore.Data.Entities;

namespace Udem.EfCore.Data.Context
{
    public class UdemyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TRKVZ11;Database=UdemyEfCore;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Birden çoğa
            modelBuilder.Entity<Product>().HasMany(x => x.SalesHistories).WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            // Birden birde
            modelBuilder.Entity<Product>().HasOne(x => x.ProductDetail).WithOne(x => x.Product)
                .HasForeignKey<ProductDetail>(x => x.ProductId);

            // Çoktan çoğa
            modelBuilder.Entity<Product>().HasMany(x => x.ProductCategories).WithOne(x => x.Product)
                .HasForeignKey(x => x.ProuctId);

            modelBuilder.Entity<Category>().HasMany(x => x.ProductCategories).WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProuctId });

            // Kolon Adı değiştir
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product_name");
            //Max karakter
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
            // Zorunlu mu ? default true
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();
            // Defaultta çalışacak yani değer girilmediyse çalışır
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("'Urun bilgisi girilmemis'");
            // aynı değerden ikinci kez girdirilemez
            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique(true);
            modelBuilder.Entity<Product>().Property(x => x.CreateDateTime).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("product_id");
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnName("product_price");
            //Hassaslık ?????
            modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 3);

            // Primary Key belirlenir
            modelBuilder.Entity<Customer>().HasKey(x=> x.CustomerId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesHistories> SalesHistories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }

    }
}
