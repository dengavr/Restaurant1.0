using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    [Table("Dishes")]
    public class Dish
    {
        [StringLength(64)]
        public string Name { get; set; }
        public int Portion { get; set; }
        [StringLength(64)]
        public string RatePortion { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
    }
}
