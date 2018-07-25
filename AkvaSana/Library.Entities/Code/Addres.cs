using Library.DomainAbstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Addreses")]
    public class Addres:DbEntity
    {
        public virtual Street Street { get; set; }
        public virtual List<Customer> Custoomers { get; set; }
        public int House { get; set; }
        [StringLength(70)]
        public string Coordinates { get; set; }
    }
}
