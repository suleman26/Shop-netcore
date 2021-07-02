using dutch_retreat.Data.Entities;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace dutch_retreat.Data
{
    public class DutchContext : IdentityDbContext<StoreUser>  
    {
        private readonly IConfiguration _config;
        

        public DutchContext(IConfiguration config)
        {
            _config = config;
          
        }
        public DbSet<Product> Products { get; set; }                                                                                                                                                                                                                                                                                                                                            
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DutchContextDb"]);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                    .HasData(

          new Product()
          {
              Id = 98,
              Productimg = "SK-A-2351",
              Price = 89000,
              Description = "500 G SSD",
              Title = "MacBook Pro",
              Category = "Laptop",
              Date = DateTime.Today
          });
            modelBuilder.Entity<Order>()
                    .HasData(
            new Order()
            {
                Id = 79,
                OrderDate = DateTime.Today,
                OrderNumber = "78"
            });

            modelBuilder.Entity<OrderItem>()
                    .HasData(

              new OrderItem()
              {
                  Id = 88,
                  Quantity = 5,
                  UnitPrice = 56
              }


              );




        }

    }
        }
    


