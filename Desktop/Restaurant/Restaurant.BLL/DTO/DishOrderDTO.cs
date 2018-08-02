using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.BLL
{
    public class DishOrderDTO
    {
        public int Id { get; set; }
        public DateTime? OrderedIn { get; set; }
        public int DishId { get; set; }
        public decimal SellPrice { get; set; }
    }

}
