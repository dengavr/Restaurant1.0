using Library.AppContext;
using Library.Entities;

namespace Library.Repositories
{
    public class AddresesRepository : DbRepository<Addres>, IAddresesRepository
    {
        public AddresesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class DeficitsRepository : DbRepository<Deficit>, IDeficitsRepository
    {
        public DeficitsRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class SupplyRepository : DbRepository<Supply>, ISupplyRepository
    {
        public SupplyRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class CitiesRepository : DbRepository<City>, ICitiesRepository
    {
        public CitiesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class CustomersRepository : DbRepository<Customer>, ICustomersRepository
    {
        public CustomersRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class DealersRepository : DbRepository<Dealer>, IDealersRepository
    {
        public DealersRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class DepartmentsRepository : DbRepository<Department>, IDepartmentsRepository
    {
        public DepartmentsRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class DistrictsRepository : DbRepository<District>, IDistrictsRepository
    {
        public DistrictsRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class DriversRepository : DbRepository<Driver>, IDriversRepository
    {
        public DriversRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class EmployeesRepository : DbRepository<Employee>, IEmployeesRepository
    {
        public EmployeesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class FuelingsRepository : DbRepository<Fueling>, IFuelingsRepository
    {
        public FuelingsRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class LoadingsRepository : DbRepository<Loading>, ILoadingsRepository
    {
        public LoadingsRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class MileagesRepository : DbRepository<Mileage>, IMileagesRepository
    {
        public MileagesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class OrdersRepository : DbRepository<Order>, IOrdersRepository
    {
        public OrdersRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class PayTypesRepository : DbRepository<PayType>, IPayTypesRepository
    {
        public PayTypesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class PhonesRepository : DbRepository<Phone>, IPhonesRepository
    {
        public PhonesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class PricesRepository : DbRepository<Price>, IPricesRepository
    {
        public PricesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class SalesRepository : DbRepository<Sale>, ISalesRepository
    {
        public SalesRepository(MyAppDbContext context) : base(context)
        {
        }
    }
    public class StreetsRepository : DbRepository<Street>, IStreetsRepository
    {
        public StreetsRepository(MyAppDbContext context) : base(context)
        {
        }
    }
}
