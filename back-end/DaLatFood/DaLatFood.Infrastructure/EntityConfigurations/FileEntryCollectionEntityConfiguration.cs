using DaLatFood.Domain.File.Entity;
using Microsoft.EntityFrameworkCore;

namespace DaLatFood.Infrastructure.EntityConfigurations;

public static class FileEntryCollectionEntityConfiguration
{
    private const string FileEntryCollectionSchemaName = "FileSchema";

    public static void ConfigFileEntryCollectionEntities(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FileEntryCollection>(builder =>
        {
            builder.ToTable("FileEntryCollection", FileEntryCollectionSchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.CreatedTime).HasDefaultValueSql("GETDATE()");
        });
    }
}