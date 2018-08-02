using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    [Table("Products")]
    public class Product
    {
        [StringLength(64)]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
