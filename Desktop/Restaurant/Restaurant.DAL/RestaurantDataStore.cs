using Restaurant.AppContext;
using Restaurant.Entities;
using System;

namespace Restaurant.DAL
{
    public class RestaurantDataStore : IDisposable
    {
        private RestaurantDbContext _ctx;

        public EfGenericRepository<Product> Products { get; set; }
        public EfGenericRepository<Receipt> Receipts { get; set; }
        public EfGenericRepository<ProductOrder> PrductOrder { get; set; }
        public EfGenericRepository<Ingredient> Ingredients { get; set; }
        public EfGenericRepository<Dish> Dishes { get; set; }
        public EfGenericRepository<DishOrder> DishOrder { get; set; }

        public RestaurantDataStore(string connectionString)
        {
            _ctx = new RestaurantDbContext(connectionString);

            Products = new EfGenericRepository<Product>(_ctx);
            Receipts = new EfGenericRepository<Receipt>(_ctx);
            PrductOrder = new EfGenericRepository<ProductOrder>(_ctx);
            Ingredients = new EfGenericRepository<Ingredient>(_ctx);
            Dishes = new EfGenericRepository<Dish>(_ctx);
            DishOrder = new EfGenericRepository<DishOrder>(_ctx);
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }

}
