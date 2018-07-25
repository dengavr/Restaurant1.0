using Library.DomainAbstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Drivers")]
    public class Driver :DbEntity
    {
        [StringLength(70)]
        public string Name { get; set; }
        public virtual List<Phone> Phones { get; set; }
        public DateTime Recruitment { get; set; }
        public DateTime Dismissal { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Loading> Loadings { get; set; }
        public virtual List<Fueling> Fuelings { get; set; }
        public virtual List<Mileage> Mileages { get; set; }
    }
}
