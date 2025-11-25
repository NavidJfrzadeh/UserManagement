using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infra.EFCore;

public static class InfrastructureEfCoreRegister
{
    public static IServiceCollection AddInfraEfCore(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UserManagementDB ;Integrated Security=True;TrustServerCertificate=True;"));

        return services;
    }
}
