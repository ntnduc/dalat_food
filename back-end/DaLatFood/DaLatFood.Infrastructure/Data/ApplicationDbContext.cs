using DaLatFood.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DaLatFood.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigProductEntities();
    }
}