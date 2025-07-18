using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineLibraryProject.Entities;

namespace OnlineLibraryProject.Entities.Repositories
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            :base(options)
        {
          
        }

       
    
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Book>()
                .HasOne<Author>()
                .WithMany(a=>a.Books)
                .HasForeignKey(a => a.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Book>()
                .HasOne<Genre>()
                .WithMany(g=>g.Books)
                .HasForeignKey(b => b.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Transaction>()
                .HasMany<User>()
                .WithOne()
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Transaction>()
                .HasMany<Book>()
                .WithOne()
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Restrict);

          /*  modelBuilder.Entity<User>().HasData(
                new User() { 
                    Id= "8d10593c-1cf8-45d9-a5c6-a7910a9d94c0",
                    Email= "admin@library.bg",
                    Password="123456",
                    Role="Admin"
                }
                );*/


        }
    }
}