using Library.DomainAbstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Employees")]
    public class Employee:DbEntity
    {
        [StringLength(70)]
        public string Name { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Phone> Phones { get; set; }
        public DateTime Recruitment { get; set; }
        public DateTime Dismissal { get; set; }
    }
}
