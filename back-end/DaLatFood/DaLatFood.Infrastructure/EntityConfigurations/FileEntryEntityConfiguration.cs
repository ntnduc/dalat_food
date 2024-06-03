using DaLatFood.Domain.File.Entity;
using Microsoft.EntityFrameworkCore;

namespace DaLatFood.Infrastructure.EntityConfigurations;

public static class FileEntryEntityConfiguration
{
    public static void ConfigFileEntryEntities(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FileEntry>(builder =>
        {
            builder.ToTable("FileEntry", "FileSchema");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
        });
    }
}