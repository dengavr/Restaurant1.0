using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    [Table("DishOrders")]
    public class DishOrder
    {
        public DateTime OrderIn { get; set; }
        public virtual Dish Dish { get; set; }
        public decimal SellPrice { get; set; }
        public DishOrder()
        {
            OrderIn = DateTime.Now;
        }
    }
}
