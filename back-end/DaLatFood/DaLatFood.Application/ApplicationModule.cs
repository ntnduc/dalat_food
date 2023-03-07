using System.Runtime.CompilerServices;
using DaLatFood.Application.Production.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        service.AddScoped<IProductService, ProductService>();
        return service;
    }
}