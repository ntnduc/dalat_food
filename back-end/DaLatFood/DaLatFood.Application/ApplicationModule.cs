using AutoMapper;
using DaLatFood.Application.Production.Dto;
using DaLatFood.Application.Production.Mapper;
using DaLatFood.Application.Production.Service;
using FluentValidation;
using FluentValidation.AspNetCore;
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
        service.AddValidatorsFromAssemblyContaining<ValidateProductCreateDto>();
        service.AddValidatorsFromAssemblyContaining<ValidateProductUpdateDto>();
        service.AddValidatorsFromAssemblyContaining<ValidateProductDetailDto>();

        //Service
        service.AddScoped<IProductService, ProductService>();
        return service;
    }
}