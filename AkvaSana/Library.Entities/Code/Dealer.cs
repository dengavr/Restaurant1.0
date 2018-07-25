using Library.DomainAbstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Dealers")]
    public class Dealer :DbEntity
    {
        [StringLength(70)]
        public string Title { get; set; }
        [StringLength(70)]
        public string Name{ get; set; }
        public virtual List<Phone> Phones { get; set; }
    }
}
