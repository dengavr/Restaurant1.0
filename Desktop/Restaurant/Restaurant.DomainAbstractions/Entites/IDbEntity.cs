using System.ComponentModel.DataAnnotations;

namespace Restaurant.DomainAbstractions
{
    public interface IDbEntity
    {
        [Key]
        int Id { get; set; }
    }
}
