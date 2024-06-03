using FluentValidation;

namespace DaLatFood.Application.Production.Dto;

public class ProductListDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
}
