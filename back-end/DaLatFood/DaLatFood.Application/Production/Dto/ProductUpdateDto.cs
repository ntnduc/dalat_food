using FluentValidation;

namespace DaLatFood.Application.Production.Dto;

public class ProductUpdateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
}

public class ValidateProductUpdateDto : AbstractValidator<ProductUpdateDto>
{
    public ValidateProductUpdateDto()
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.Name).NotNull();
        RuleFor(x => x.Price).NotNull();
    }
}