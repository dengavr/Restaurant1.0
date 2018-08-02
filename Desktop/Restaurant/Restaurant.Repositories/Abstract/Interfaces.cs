using Restaurant.DomainAbstractions;
using Restaurant.Entities;

namespace Restaurant.Repositories
{
    public interface IDishesRepository : IDbRepository<Dish>
    {
    }
    public interface IDishOrdersRepository : IDbRepository<DishOrder>
    {
    }
    public interface IIngredientsRepository : IDbRepository<Ingredient>
    {
    }
    public interface IProductsRepository : IDbRepository<Product>
    {
    }
    public interface IProductOrdersRepository : IDbRepository<ProductOrder>
    {
    }
    public interface IReceiptsRepository : IDbRepository<Receipt>
    {
    }
}
