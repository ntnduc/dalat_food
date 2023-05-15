using DaLatFood.Application;
using DaLatFood.Infrastructure;
using DaLatFood.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");
// Add services to the container.
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
// .AddDomain();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(a =>
{
    a.SwaggerDoc("v1", new OpenApiInfo { Title = "Da Lat Food", Version = "v1" });
    a.CustomSchemaIds(i => i.FullName);
});
//Db context
builder.Services.AddDbContext<ApplicationDbContext>(options => { options.UseSqlServer(connectionString); });

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
app.UseEndpoints(endPoints => endPoints.MapControllers());
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSpa(spa =>
    {
        spa.UseProxyToSpaDevelopmentServer("https://localhost:3000");
    });
}

// app.UseHttpsRedirection();

app.MapControllers();

app.Run();