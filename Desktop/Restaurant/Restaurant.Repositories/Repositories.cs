using Restaurant.Entities;
using Restaurant.AppContext;


namespace Restaurant.Repositories
{
    public class DishesRepository : DbRepository<Dish>, IDishesRepository
    {
        public DishesRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
    public class DishOrdersRepository : DbRepository<DishOrder>, IDishOrdersRepository
    {
        public DishOrdersRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
    public class IngredientsRepository : DbRepository<Ingredient>, IIngredientsRepository
    {
        public IngredientsRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
    public class ProductsRepository : DbRepository<Product>, IProductsRepository
    {
        public ProductsRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
    public class ProductOrdersRepository : DbRepository<ProductOrder>, IProductOrdersRepository
    {
        public ProductOrdersRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
    public class ReceiptsRepository : DbRepository<Receipt>, IReceiptsRepository
    {
        public ReceiptsRepository(RestaurantDbContext context) : base(context)
        {
        }
    }
}
