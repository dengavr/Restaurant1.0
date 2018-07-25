using Library.DomainAbstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Streets")]
    public class Street :DbEntity
    {
        [StringLength(70)]
        public string Name { get; set; }
        [StringLength(70)]
        public string OldName { get; set; }
        public virtual City City { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public virtual List<Addres> Addreses { get; set; }
    }
}
