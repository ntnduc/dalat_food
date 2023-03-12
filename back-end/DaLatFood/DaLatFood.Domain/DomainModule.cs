using System.Runtime.CompilerServices;
using DaLatFood.Application.Production.Service;
using DaLatFood.Domain.Product.Entity;
using DaLatFood.Domain.Product.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Domain;
public static class DomainModule
{
    public static IServiceCollection AddDomain(this IServiceCollection service)
    {
        return service;
    }
}