global using Microsoft.EntityFrameworkCore;
using DaLatFood.WebApi;

namespace DaLatFood.Migrator;

public class Startup
{
    private IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection service)
    {
        
        service.AddDbContext<MigrationDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("Default"));
        });
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env){}
}