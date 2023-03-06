using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        return service;
    }
}