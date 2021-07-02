using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dutch_retreat.ModelViews
{
    public class ProductModelView
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Productimg { get; set; }
        public DateTime Date { get; set; }
    }
}
