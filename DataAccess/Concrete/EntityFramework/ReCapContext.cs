﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Car>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Car>().Property(c => c.BrandId).HasColumnName("BrandId");
            modelBuilder.Entity<Car>().Property(c => c.ColorId).HasColumnName("ColorId");
            modelBuilder.Entity<Car>().Property(c => c.ModelYear).HasColumnName("ModelYear");
            modelBuilder.Entity<Car>().Property(c => c.DailyPrice).HasColumnName("DailyPrice");
            modelBuilder.Entity<Car>().Property(c => c.Description).HasColumnName("Description");

            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Brand>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Brand>().Property(c => c.Name).HasColumnName("Name");

            modelBuilder.Entity<Color>().ToTable("Colors");
            modelBuilder.Entity<Color>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Color>().Property(c => c.Name).HasColumnName("Name");

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().Property(u => u.Id).HasColumnName("Id");
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasColumnName("FirstName");
            modelBuilder.Entity<User>().Property(u => u.LastName).HasColumnName("LastName");
            modelBuilder.Entity<User>().Property(u => u.Email).HasColumnName("Email");
            modelBuilder.Entity<User>().Property(u => u.Password).HasColumnName("Password");

            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Customer>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Customer>().Property(c => c.UserId).HasColumnName("UserId");
            modelBuilder.Entity<Customer>().Property(c => c.CompanyName).HasColumnName("CompanyName");

            modelBuilder.Entity<Rental>().ToTable("Rentals");
            modelBuilder.Entity<Rental>().Property(r => r.Id).HasColumnName("Id");
            modelBuilder.Entity<Rental>().Property(r => r.CarId).HasColumnName("CarId");
            modelBuilder.Entity<Rental>().Property(r => r.CustomerId).HasColumnName("CustomerId");
            modelBuilder.Entity<Rental>().Property(r => r.RentDate).HasColumnName("RentDate");
            modelBuilder.Entity<Rental>().Property(r => r.ReturnDate).HasColumnName("ReturnDate");
        }
    }
}
