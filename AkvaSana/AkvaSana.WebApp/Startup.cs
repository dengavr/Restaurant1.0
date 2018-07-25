using Library.AppContext;
using Library.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AkvaSana.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("LocalConnection")));
            services.AddMvc();
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddTransient<IEmployeesRepository, EmployeesRepository>();
            services.AddTransient<IAddresesRepository, AddresesRepository>();
            services.AddTransient <ICitiesRepository, CitiesRepository> ();
            services.AddTransient <ICustomersRepository, CustomersRepository> ();
            services.AddTransient <IDealersRepository, DealersRepository> ();
            services.AddTransient <IDeficitsRepository, DeficitsRepository> ();
            services.AddTransient <IDepartmentsRepository, DepartmentsRepository> ();
            services.AddTransient <IDriversRepository, DriversRepository> ();
            services.AddTransient <IFuelingsRepository, FuelingsRepository> ();
            services.AddTransient <ILoadingsRepository, LoadingsRepository> ();
            services.AddTransient <IMileagesRepository, MileagesRepository> ();
            services.AddTransient <IOrdersRepository, OrdersRepository> ();
            services.AddTransient <IPayTypesRepository, PayTypesRepository> ();
            services.AddTransient <IPhonesRepository, PhonesRepository> ();
            services.AddTransient <IPricesRepository, PricesRepository> ();
            services.AddTransient <ISalesRepository, SalesRepository> ();
            services.AddTransient <IStreetsRepository, StreetsRepository> ();
            services.AddTransient <ISupplyRepository, SupplyRepository> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
