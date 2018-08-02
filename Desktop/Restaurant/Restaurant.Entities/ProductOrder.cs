using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    [Table("ProductOrders")]
    public class ProductOrder
    {
        public DateTime OrderIn { get; set; }
        public virtual Product Product { get; set; }
        public float Quantity { get; set; }
        public ProductOrder()
        {
            OrderIn = DateTime.Now;
        }
    }

}
