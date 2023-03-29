using DaLatFood.Domain.Core;
using DaLatFood.Domain.File.Entity;

namespace DaLatFood.Domain.Product.Entity;

public class Production : Entity<Guid>
{
    public string Name { get; set; }
    public string Price { get; set; }
    public string Code { get; set; }
}