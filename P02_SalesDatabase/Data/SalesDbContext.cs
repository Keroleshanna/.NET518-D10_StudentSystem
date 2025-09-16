using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Data
{
    internal class SalesDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=SalesDatabase;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);


            modelBuilder.Entity<Product>()
                .Property(e => e.Quantity)
                .HasColumnType("decimal(18,2)");


            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .HasMaxLength(250)
                .HasDefaultValue("No description");


            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(true);


            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false);


            modelBuilder.Entity<Store>()
                .Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(true);


            modelBuilder.Entity<Sale>()
                .Property(e => e.Date)
                .HasDefaultValueSql("GETDATE()");

        }


    }
}
