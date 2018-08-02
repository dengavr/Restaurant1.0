using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{

    [Table("Ingredients")]
    public class Ingredient
    {
        public float Quantity { get; set; }
        [StringLength(64)]
        public string RatePortion { get; set; }
        public virtual Product Product { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
