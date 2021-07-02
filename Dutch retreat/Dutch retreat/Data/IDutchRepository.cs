using DutchTreat.Data.Entities;
using System.Collections.Generic;

namespace dutch_retreat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Product> GetProductsByCategory(string category);
        Order GetOrderById(int id);
        void AddEntity(object model);
        bool SaveAll();
        
    }
}