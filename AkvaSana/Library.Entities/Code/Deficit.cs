using Library.DomainAbstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Deficits")]
    public class Deficit : DbEntity
    {
        public DateTime DateTime { get; set; }
        public virtual List<Loading> Loading { get; set; }
        public int Number { get; set; }
        [StringLength(200)]
        public string Notes { get; set; }
    }
}
