using System.ComponentModel.DataAnnotations;
using DaLatFood.Domain.Core;
using DaLatFood.Domain.File.Entity;

namespace DaLatFood.Domain.Product.Entity;

public class Production : Entity<Guid>
{
    public string Name { get; set; }
    public string Price { get; set; }
    
    [MinLength(5)] public string Code { get; set; }
    public FileEntryCollection FileEntryCollection { get; set; }

    public void SetCode(string code)
    {
        Code = code.ToUpper();
    }
}