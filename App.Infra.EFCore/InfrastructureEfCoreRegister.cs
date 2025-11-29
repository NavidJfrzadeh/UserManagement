using App.Infra.EFCore.Repositories;
using App.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infra.EFCore;

public static class InfrastructureEfCoreRegister
{
    public static IServiceCollection AddInfraEfCore(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<AppDbContext>(options =>
        //    options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))); // not working
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IAdminRepository, AdminRepository>();
        return services;
    }
}
