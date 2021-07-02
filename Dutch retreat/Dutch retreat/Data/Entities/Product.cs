using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Productimg { get; set; }
        public DateTime Date { get; set; }


        public static implicit operator Product(List<Product> v)
        {
            throw new NotImplementedException();
        }
    }
}