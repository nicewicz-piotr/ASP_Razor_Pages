﻿using System;
using Microsoft.EntityFrameworkCore;

namespace CS7
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public Northwind(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder: modelBuilder);

            modelBuilder.Entity<Category>().Property(c => c.CategoryName).IsRequired().HasMaxLength(15);

            modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category);

            modelBuilder.Entity<Customer>().Property(c => c.CustomerID).IsRequired().HasMaxLength(5);

            modelBuilder.Entity<Customer>().Property(c => c.CompanyName).IsRequired().HasMaxLength(40);

            modelBuilder.Entity<Customer>().Property(c => c.ContactName).HasMaxLength(30);

            modelBuilder.Entity<Customer>().Property(c => c.Country).HasMaxLength(15);

            modelBuilder.Entity<Employee>().Property(c => c.LastName).IsRequired().HasMaxLength(20);

            modelBuilder.Entity<Employee>().Property(c => c.FirstName).IsRequired().HasMaxLength(10);

            modelBuilder.Entity<Employee>().Property(c => c.Country).IsRequired().HasMaxLength(15);

            modelBuilder.Entity<Product>().Property(c => c.ProductName).IsRequired().HasMaxLength(40);

            modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Products);

            modelBuilder.Entity<Product>().HasOne(p => p.Supplier).WithMany(c => c.Products);

            modelBuilder.Entity<OrderDetail>().ToTable("Order Details");

            modelBuilder.Entity<OrderDetail>().HasKey(od => new {od.OrderID, od.ProductID});

            modelBuilder.Entity<Supplier>().Property(c => c.CompanyName).IsRequired().HasMaxLength(40);

            modelBuilder.Entity<Supplier>().HasMany(c => c.Products).WithOne(p => p.Supplier);

            modelBuilder.Entity<Shipper>().HasKey(b => b.ShipVia).HasName("ShipperID"); //odwołuj się do nazwy w bazie danych "ShipperID"

        }
        
    }
}
