using DaLatFood.Infrastructure.EntityConfigurations;

namespace DaLatFood.Migrator;

public class MigrationDbContext : DbContext
{
    public MigrationDbContext(DbContextOptions<MigrationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigProductEntities();
        modelBuilder.ConfigFileEntryCollectionEntities();
    }
    
}