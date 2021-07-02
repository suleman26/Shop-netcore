using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dutch_retreat.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _ctx;
        private readonly IWebHostEnvironment _env;

        public DutchSeeder(DutchContext ctx, IWebHostEnvironment env)
        {
            _ctx = ctx;
            _env = env;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated(); 
            if (!_ctx.Products.Any())
            {
                var filePath = Path.Combine(_env.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filePath);
                var products = JsonSerializer.Deserialize<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);

                var order = new Order()
                {
                    OrderNumber = "62783",
                    OrderDate = DateTime.Today,
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                        Product = products.First(),
                        Quantity = 5,
                        UnitPrice = products.First().Price
                        }
                    }
                     
                };
                
            }
            _ctx.SaveChanges();
        }
    }
}
