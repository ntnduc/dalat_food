using DaLatFood.Application.Common.Interface.Authentication;
using DaLatFood.Application.Common.Interface.DateTimeProvider;
using DaLatFood.Infrastructure.Authentication.Model;
using DaLatFood.Infrastructure.Authentication.Service;
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
        service.Configure<JwtSettingsModel>(configurationManager.GetSection(JwtSettingsModel.SectionName));
        service.AddSingleton<IJwtTokenGenerator, JwTokenGenerator>();
        service.AddSingleton<IDateTimeProvider, DateTimeProviderService>();
        return service;
    }
}