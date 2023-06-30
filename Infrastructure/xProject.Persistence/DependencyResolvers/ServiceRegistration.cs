using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using xProject.Persistence.Configurations;
using xProject.Persistence.Contexts;

namespace xProject.Persistence.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddPresentationServices(this IServiceCollection services)
        {
            services.AddDbContext<MsSqlxProjectContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
