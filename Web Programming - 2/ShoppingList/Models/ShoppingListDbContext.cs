using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class ShoppingListDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public ShoppingListDbContext()
        {
            this.Categories = this.Set<Category>();
            this.Products = this.Set<Product>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
             .UseSqlServer(@"Server=localhost;Database=ShoppingListDbContext;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany<Product>();

            modelBuilder.Entity<Product>()
                .HasOne<Category>()
                .WithMany()
                .HasForeignKey(a => a.CategoryID)
                .OnDelete(DeleteBehavior.Restrict);
                

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name= "Хранителни продукти",
                });
            modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 2,
                Name = "Дрехи, обувки и аксесоари",
            });

            modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 3,
                Name = "За дома",
            });

            modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 4,
                Name = "За домашния любиимец",
            });

        }
    }
}
