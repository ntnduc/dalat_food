using AutoMapper;
using DaLatFood.Application.Production.Mapper;
using DaLatFood.Application.Production.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile<MapProductProfile>();
        });
        IMapper mapper = mapperConfig.CreateMapper();
        service.AddSingleton(mapper);
        service.AddScoped<IProductService, ProductService>();
        return service;
    }
}