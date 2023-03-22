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
        RuleFor(x => x.Name).NotNull().NotEmpty();
        RuleFor(x => x.Price).NotNull();
    }
}