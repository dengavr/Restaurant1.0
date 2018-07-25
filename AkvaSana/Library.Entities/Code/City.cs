using Library.DomainAbstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Cities")]
    public class City :DbEntity
    {
        [StringLength(70)]
        public string Name { get; set; }
        public virtual List<Street> Streets { get; set; }
    }
}
