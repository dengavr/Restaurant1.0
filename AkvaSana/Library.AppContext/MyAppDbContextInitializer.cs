using Library.Entities;
using System.Data.Entity;

namespace Library.AppContext
{
    public class MyAppDbContextInitializer : DropCreateDatabaseAlways<MyAppDbContext>
    {
        protected override void Seed(MyAppDbContext context)
        {
           
        }
        
    }
}
