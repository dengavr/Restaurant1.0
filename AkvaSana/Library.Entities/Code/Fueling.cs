using Library.DomainAbstractions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Fuelings")]
    public class Fueling :DbEntity
    {
        public int Petrol { get; set; }
        public int Gas { get; set; }
        public virtual Driver Driver { get; set; }
        public DateTime DateTime { get; set; }
    }
}
