using Microsoft.EntityFrameworkCore;
using FirstProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace FirstProject.DataAccess.Data;
public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<OrderHeader> OrderHeaders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "khaled", DisplayOrder = 1, CreateDateTime = DateTime.Now },
            new Category { Id = 2, Name = "zakaria", DisplayOrder = 2, CreateDateTime = DateTime.Now },
            new Category { Id = 3, Name = "alshammi", DisplayOrder = 3, CreateDateTime = DateTime.Now }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "Fortune of Time",
                Author = "Billy Spark",
                Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                ISBN = "SWD9999001",
                ListPrice = 99,
                Price = 90,
                Price50 = 85,
                Price100 = 80,
                CategoryId = 1,
            },
            new Product
            {
                Id = 2,
                Title = "Dark Skies",
                Author = "Nancy Hoover",
                Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                ISBN = "CAW777777701",
                ListPrice = 40,
                Price = 30,
                Price50 = 25,
                Price100 = 20,
                CategoryId = 2,
            },
            new Product
            {
                Id = 3,
                Title = "Vanish in the Sunset",
                Author = "Julian Button",
                Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                ISBN = "RITO5555501",
                ListPrice = 55,
                Price = 50,
                Price50 = 40,
                Price100 = 35,
                CategoryId = 3,
            }
        );
    }
}
