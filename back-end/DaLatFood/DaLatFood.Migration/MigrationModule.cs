using DaLatFood.WebApi;

namespace DaLatFood.Migration;

public class MigrationModule
{
    public static IServiceCollection AppMigrationModule(IServiceCollection service)
    {
        service.AddDbContext<MigrationDbContext>();
        return service;
    }
}