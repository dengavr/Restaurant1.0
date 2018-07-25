using Library.DomainAbstractions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Mileages")]
    public class Mileage :DbEntity
    {
        public int Morning { get; set; }
        public int End { get; set; }
        public virtual Driver Driver { get; set; }
        public DateTime Date { get; set; }
    }
}
