using Library.DomainAbstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    [Table("Prices")]
    public class Price :DbEntity
    {
        public int Bottle { get; set; }
        public int Deposit { get; set; }
        public int Pump { get; set; }
    }
}
