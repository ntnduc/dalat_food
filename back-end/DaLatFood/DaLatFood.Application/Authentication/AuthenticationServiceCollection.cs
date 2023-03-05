using DaLatFood.Application.Authentication.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Application.Authentication;

public static class AuthenticationServiceCollection
{
    public static IServiceCollection AddAuthenticationServiceCollection(this IServiceCollection service)
    {
        service.AddScoped<IAuthenticationService, AuthenticationService>();
        return service;
    }
}