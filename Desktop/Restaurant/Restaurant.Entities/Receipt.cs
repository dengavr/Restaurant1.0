using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    [Table("Recipes")]
    public class Receipt
    {
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
    }
}
