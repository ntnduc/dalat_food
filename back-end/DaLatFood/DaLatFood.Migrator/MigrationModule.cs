using DaLatFood.WebApi;

namespace DaLatFood.Migrator;

public class MigrationModule
{
    public static IServiceCollection AppMigrationModule(IServiceCollection service)
    {
        service.AddDbContext<MigrationDbContext>();
        return service;
    }
}