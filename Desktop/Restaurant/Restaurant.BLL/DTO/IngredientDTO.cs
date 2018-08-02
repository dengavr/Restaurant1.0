using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.BLL
{
    public class IngredientDTO
    {
        public int Id { get; set; }
        public int DishId { get; set; }
        public int ProductId { get; set; }
        public float Quantity { get; set; }
        public string RatePortion { get; set; }
    }

}
