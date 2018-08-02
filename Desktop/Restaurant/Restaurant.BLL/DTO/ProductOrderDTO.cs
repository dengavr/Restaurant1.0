using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.BLL
{
    public class ProductOrderDTO
    {
        public int Id { get; set; }
        public DateTime? OrderedIn { get; set; }
        public int ProductId { get; set; }
        public float Quantity { get; set; }
    }

}
