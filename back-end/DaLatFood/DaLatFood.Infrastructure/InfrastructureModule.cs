using DaLatFood.Application.Common.Interface.DateTimeProvider;
using DaLatFood.Infrastructure.Data;
using DaLatFood.Infrastructure.DateTimeProvider.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Infrastructure;

public static class InfrastructureModule 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service,
        ConfigurationManager configurationManager)
    {
        service.AddDbContext<ApplicationDbContext>();
        service.AddSingleton<IDateTimeProvider, DateTimeProviderService>();
        return service;
    }
}