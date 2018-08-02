using System.Data.Entity;

namespace Restaurant.AppContext
{
    public class RestaurantDbInitializer : DropCreateDatabaseAlways<RestaurantDbContext>
    {
        protected override void Seed(RestaurantDbContext context)
        {

        }

    }
}
