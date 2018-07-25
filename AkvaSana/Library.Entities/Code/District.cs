using Library.DomainAbstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Districts")]
    public class District :DbEntity
    {
        [StringLength(70)]
        public string Name { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
