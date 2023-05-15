using DaLatFood.Domain.Product.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DaLatFood.Infrastructure.EntityConfigurations;

public static class ProductEntityConfiguration
{
    private const string ProductSchemaName = "ProductSchema";

    public static void ConfigProductEntities(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Production>(builder =>
        {
            builder.ToTable("Product", ProductSchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.HasOne(x => x.FileEntryCollection);
        });
    }

    public static void ConfigProductSaveChange(DbContext context)
    {
        foreach (var entity in context.ChangeTracker.Entries<Production>())
        {
            if (entity.Entity.Code != null)
            {
                entity.Entity.SetCode(entity.Entity.Code);
            }
        }
    }

}