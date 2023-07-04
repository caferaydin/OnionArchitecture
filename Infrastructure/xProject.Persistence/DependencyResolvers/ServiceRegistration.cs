using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using xProject.Application.Abstract.Repositoriy.ReadRepository;
using xProject.Application.Abstract.Repositoriy.WriteRepository;
using xProject.Persistence.Concrete.Repository;
using xProject.Persistence.Configurations;
using xProject.Persistence.Contexts;

namespace xProject.Persistence.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddPresentationServices(this IServiceCollection services)
        {
            services.AddDbContext<MsSqlxProjectContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();


        }
    }
}
