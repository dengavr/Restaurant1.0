using Library.DomainAbstractions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Loadings")]
    public class Loading :DbEntity
    {
        public DateTime DateTime { get; set; }
        public virtual Driver Driver { get; set; }
        public int BottleIn { get; set; }
        public int BottleOut { get; set; }
        public int InCar { get; set; }
        public Deficit Deficit { get; set; }
        public Supply Return { get; set; }
        [StringLength(200)]
        public string Notes { get; set; }
    }
}
