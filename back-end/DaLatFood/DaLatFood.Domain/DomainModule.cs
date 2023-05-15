using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Domain;
public static class DomainModule
{
    public static IServiceCollection AddDomain(this IServiceCollection service)
    {
        return service;
    }
}