using DaLatFood.Domain.Product.Repositories;

namespace DaLatFood.Domain.Product.Entity;

public class Production
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
}