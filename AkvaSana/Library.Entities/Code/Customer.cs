using Library.DomainAbstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Customers")]
    public class Customer:DbEntity
    {
        public virtual Addres Addres { get; set; }
        public virtual District District { get; set; }
        public virtual Street Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }
        public int Code { get; set; }
        public virtual List<Phone> Phones { get; set; }
        public virtual PayType PayType { get; set; }
        public int Debt { get; set; }
        public DateTime DateRegistration { get; set; }
        [StringLength(200)]
        public string Notes { get; set; }

    }
}
