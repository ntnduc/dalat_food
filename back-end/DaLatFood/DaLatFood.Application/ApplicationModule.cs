using System.Reflection;
using AutoMapper;
using DaLatFood.Application.Common;
using DaLatFood.Application.Production.Mapper;
using DaLatFood.Application.Production.Service;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        //Mapper
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile<MapProductProfile>();
        });
        IMapper mapper = mapperConfig.CreateMapper();
        service.AddSingleton(mapper);
        
        //Validate
        service.AddTransient<IValidateModel, ValidateModel>();
        service.AddValidatorsFromAssembly(typeof(ValidateModel).Assembly);
        // service.AddFluentValidationAutoValidation();

        //Service
        service.AddScoped<IProductService, ProductService>();
        return service;
    }
}