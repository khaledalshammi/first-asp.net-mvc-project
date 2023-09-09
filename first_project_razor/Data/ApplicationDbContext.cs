using first_project_razor.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace first_project_razor.Data;
    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "khaled", DisplayOrder = 1, CreateDateTime = DateTime.Now },
            new Category { Id = 2, Name = "zakaria", DisplayOrder = 2, CreateDateTime = DateTime.Now },
            new Category { Id = 3, Name = "alshammi", DisplayOrder = 3, CreateDateTime = DateTime.Now }
            );
    }
}
