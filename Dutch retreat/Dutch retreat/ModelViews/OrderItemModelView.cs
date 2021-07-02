using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dutch_retreat.ModelViews
{
    public class OrderItemModelView
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        public int ProductId { get; set; }


        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string ProductProductimg { get; set; }
        public DateTime ProductDate { get; set; }

    }

}
