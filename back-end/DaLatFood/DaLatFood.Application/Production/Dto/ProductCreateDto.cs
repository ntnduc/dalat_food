using FluentValidation;

namespace DaLatFood.Application.Production.Dto;

public class ProductCreateDto
{
    public string Name { get; set; }
    public string Price { get; set; }
}

public class ValidateProductCreateDto : AbstractValidator<ProductCreateDto>
{
    public ValidateProductCreateDto()
    {
        
    }
}