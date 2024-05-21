using DeerCoffeeShop.Domain.Common.Interfaces;
using DeerCoffeeShop.Domain.Repositories;
using DeerCoffeeShop.Infrastructure.Persistence.Configurations;
using DeerCoffeeShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeerCoffeeShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>((sp, options) =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("AzureConnection"),
                    b =>
                    {
                        b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                        b.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    });
                options.UseLazyLoadingProxies();


            });
            services.AddScoped<IUnitOfWork>(provider => provider.GetRequiredService<ApplicationDbContext>());
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
