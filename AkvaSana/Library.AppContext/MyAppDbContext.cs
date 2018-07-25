using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AppContext
{
    public class MyAppDbContext:DbContext
    {
        public DbSet<Addres> Addreses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Driver>Drivers { get; set; }
        public DbSet<Fueling> Fuelings { get; set; }
        public DbSet<Loading> Loadings { get; set; }
        public DbSet<Mileage> Mileages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PayType> PayTypes { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<Deficit> Deficits { get; set; }

        public MyAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        public class MyContextFactory : IDbContextFactory<MyAppDbContext>
        {
            public MyAppDbContext Create()
            {
                return new MyAppDbContext("MyDatabase");
            }
        }
        static MyAppDbContext()
        {
            Database.SetInitializer(new MyAppDbContextInitializer());
            
        }
    }
}
