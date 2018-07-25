using Library.DomainAbstractions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Sales")]
    public class Sale :DbEntity
    {
        public virtual Dealer Dealer { get; set; }
        public DateTime DateTime { get; set; }
        public int BottleIn { get; set; }
        public int BottleOut { get; set; }
        public int OnBase { get; set; }
        [StringLength(200)]
        public string Notes { get; set; }
    }
}
