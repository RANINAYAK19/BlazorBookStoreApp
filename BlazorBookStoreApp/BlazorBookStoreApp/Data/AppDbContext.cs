using Microsoft.EntityFrameworkCore;
using BlazorBookStoreApp.Models;

namespace BlazorBookStoreApp.Data
{
       public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Book> Books { get; set; }

            public DbSet<Product> Products { get; set; }

            public DbSet<Post> Posts { get; set; }

            public DbSet<Order> Orders { get; set; }
            public DbSet<Customer> Customers { get; set; }
    }
  }

