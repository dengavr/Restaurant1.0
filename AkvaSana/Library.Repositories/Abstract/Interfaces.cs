using Library.DomainAbstractions;
using Library.Entities;

namespace Library.Repositories
{
    public interface ICitiesRepository : IDbRepository<City>
    {
    }
    public interface IAddresesRepository : IDbRepository<Addres>
    {
    }
    public interface ISupplyRepository : IDbRepository<Supply>
    {
    }
    public interface IDeficitsRepository : IDbRepository<Deficit>
    {
    }
    public interface ICustomersRepository : IDbRepository<Customer>
    {
    }
    public interface IDealersRepository : IDbRepository<Dealer>
    {
    }
    public interface IDepartmentsRepository : IDbRepository<Department>
    {
    }
    public interface IDistrictsRepository : IDbRepository<District>
    {
    }
    public interface IDriversRepository : IDbRepository<Driver>
    {
    }
    public interface IEmployeesRepository : IDbRepository<Employee>
    {
    }
    public interface IFuelingsRepository : IDbRepository<Fueling>
    {
    }
    public interface ILoadingsRepository : IDbRepository<Loading>
    {
    }
    public interface IMileagesRepository : IDbRepository<Mileage>
    {
    }
    public interface IOrdersRepository : IDbRepository<Order>
    {
    }
    public interface IPayTypesRepository : IDbRepository<PayType>
    {
    }
    public interface IPhonesRepository : IDbRepository<Phone>
    {
    }
    public interface IPricesRepository : IDbRepository<Price>
    {
    }
    public interface ISalesRepository : IDbRepository<Sale>
    {
    }
    public interface IStreetsRepository : IDbRepository<Street>
    {
    }
}
