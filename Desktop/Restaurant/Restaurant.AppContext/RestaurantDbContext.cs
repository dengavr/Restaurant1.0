using Restaurant.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Restaurant.AppContext
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishOrder> DishOrders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Receipt> Receipts { get; set; }


        public RestaurantDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        public class MyContextFactory : IDbContextFactory<RestaurantDbContext>
        {
            public RestaurantDbContext Create()
            {
                return new RestaurantDbContext("MyDatabase");
            }
        }
        static RestaurantDbContext()
        {
            Database.SetInitializer(new RestaurantDbInitializer());

        }
    }
}
