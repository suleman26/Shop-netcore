using dutch_retreat.Data.Entities;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<StoreUser> _userManager;

        public DutchSeeder(DutchContext ctx, IWebHostEnvironment env, UserManager<StoreUser> userManager)
        {
            _ctx = ctx;
            _env = env;
            _userManager = userManager;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            StoreUser user = new StoreUser()
            {
                FirstName = "Suleman",
                LastName = "Sani",
                Email = "sulemansani26@gmail.com",
                UserName = "sulemansani26@gmail.com",
            };

            var result = _userManager.CreateAsync(user, "P7hgssw0rd123");

       

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
           
        }
    }
}
