using DaLatFood.Application.Common.Interface.DateTimeProvider;
using DaLatFood.Domain;
using DaLatFood.Domain.Product.Repositories;
using DaLatFood.Infrastructure.Data;
using DaLatFood.Infrastructure.DateTimeProvider.Service;
using DaLatFood.Infrastructure.Repositories.Product;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Infrastructure;

public static class InfrastructureModule 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service,
        ConfigurationManager configurationManager)
    {
        service.AddDbContext<ApplicationDbContext>();
        service.AddScoped<IProductRepository, ProductRepository>();
        service.AddSingleton<IDateTimeProvider, DateTimeProviderService>();
        return service;
    }
}