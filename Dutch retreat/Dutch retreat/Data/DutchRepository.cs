using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace dutch_retreat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext _ctx;
        private readonly ILogger<DutchRepository> _logger;


        public DutchRepository(DutchContext ctx, ILogger<DutchRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }
        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }

        public IEnumerable<Order> GetAllOrders(bool includeItems = true)
        {
            try
            {
                if (includeItems)
                {
                    _logger.LogInformation("GetAllOrders method was called");
                    return _ctx.Orders
                   .Include(o => o.Items)
                   .ThenInclude(p => p.Product)
                   .ToList();
                }
                else
                {
                    _logger.LogInformation("GetAllOrders method was called");
                    return _ctx.Orders
                   .ToList();
                }
               

            }
            catch (Exception ex)
            {
                _logger.LogError($"Unable to get all orders: {ex}");
                return null;

            }         
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                _logger.LogInformation("GetAllProducts method called");
                return _ctx.Products.FromSqlRaw("select * from products").ToList();
               // return _ctx.Products
               //     .OrderBy(p => p.Title)
                 //   .ToList();
            }
            catch (Exception ex)
            {  
                _logger.LogError($"Unable to get products: {ex}");
                return null;  
            }
        }

        public Order GetOrderById(int id)
        {
            try
            {
                _logger.LogInformation("GetOderById method was called");
                return _ctx.Orders
                .Where(i => i.Id == id)
                .Include(o => o.Items)
                .ThenInclude(p => p.Product)
                .FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Unable to get orders by id: {ex}");
                return null;
            }
            
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            try
            {
                _logger.LogInformation("GetProductsByCategory method was called");
                return _ctx.Products
               .Where(p => p.Category == category)
               .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Unable to get products by category: {ex}");
                return null;
            }
           
        }

        public bool SaveAll()
        {
                return _ctx.SaveChanges() > 0;   
        }
    }
}
