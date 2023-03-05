using DaLatFood.Domain.Product.Entity;
using Microsoft.EntityFrameworkCore;

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
        });
    }
}