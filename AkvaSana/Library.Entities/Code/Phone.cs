using Library.DomainAbstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Phones")]
    public class Phone :DbEntity
    {
        public int PhoneNumber { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Dealer Dealer { get; set; }
    }
}
