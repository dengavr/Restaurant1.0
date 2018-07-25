using Library.DomainAbstractions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Orders")]
    public class Order :DbEntity
    {
        public virtual Customer Customer { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOk { get; set; }
        public int NumBottle { get; set; }
        public int NumPump { get; set; }
        public int Deposit { get; set; }
        public virtual Driver Driver { get; set; }
        public int Pay { get; set; }
        [StringLength(200)]
        public string Notes { get; set; }

    }
}
