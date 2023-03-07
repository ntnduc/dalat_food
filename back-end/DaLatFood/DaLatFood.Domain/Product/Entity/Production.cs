using DaLatFood.Domain.Core;
using DaLatFood.Domain.Product.Repositories;

namespace DaLatFood.Domain.Product.Entity;

public class Production : Entity<Guid>
{
    public string Name { get; set; }
    public string Price { get; set; }
}