using System.Collections.Generic;
using System.Linq;

namespace Restaurant.DomainAbstractions
{
    public interface IDbRepository<T>
        where T : class, IDbEntity
    {
        bool AddItem(T item);
        bool AddItems(IEnumerable<T> items);
        IQueryable<T> AllItems { get; }
        bool ChangeItem(T item);
        bool DeleteItem(int id);
        T GetItem(int id);
        bool SaveChanges();
    }
}
