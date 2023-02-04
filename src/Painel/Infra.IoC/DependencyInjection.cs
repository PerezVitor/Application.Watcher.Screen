using Painel.Application.DTOs;
using Painel.Application.Interfaces;
using Painel.Application.Services;

namespace Painel.Infra.IoC;
internal static class DependencyInjection
{
    public static IServiceCollection AddAppDependencies(this IServiceCollection services)
    {
        services.AddScoped<IExceptionService, ExceptionService>();
        services.AddScoped<IResponseService, ResponseService>();
        services.AddScoped<ILoggerService, LoggerService>();
        services.AddScoped<IRequestService, RequestService>();

        services.AddScoped<ExceptionOutput>();
        services.AddScoped<LogOutput>();
        services.AddScoped<RequestOutput>();
        services.AddScoped<ResponseOutput>();

        return services;
    }
}
