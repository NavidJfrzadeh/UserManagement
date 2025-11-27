using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace App.Services;

public static class AppServiceRegistration
{
    public static IServiceCollection AddAppServiceRegistration(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}
