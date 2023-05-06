using Microsoft.EntityFrameworkCore;
using Painel.Domain.Interfaces;
using Painel.Infra.Data.Context;
using Painel.Infra.Data.Repositories;

namespace Painel.Infra.IoC;
internal static class DependencyInjectionDbContext
{
    public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(opt 
            => opt.UseSqlServer(configuration.GetConnectionString("AppWatcher"))
        );

        services.AddScoped<IExceptionRepository, ExceptionRepository>();
        services.AddScoped<IResponseRepository, ResponseRepository>();
        services.AddScoped<ILoggerRepository, LoggerRepository>();
        services.AddScoped<IRequestRepository, RequestRepository>();

        return services;
    }
}
