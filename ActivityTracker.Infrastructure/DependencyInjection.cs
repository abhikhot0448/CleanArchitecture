using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Infrastructure.Data;
using ActivityTracker.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ActivityTracker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<ApplicationDbContext>(options => 
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            service.AddScoped<IUserRepository, UserRepository>();

            return service;
        }
    }
}
