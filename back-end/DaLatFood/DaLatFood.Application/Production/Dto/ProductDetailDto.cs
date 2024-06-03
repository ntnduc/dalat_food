using FluentValidation;

namespace DaLatFood.Application.Production.Dto;

public class ProductDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
}

public class ValidateProductDetailDto : AbstractValidator<ProductDetailDto>
{
    public ValidateProductDetailDto()
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.Name).NotNull();
        RuleFor(x => x.Price).NotNull();
    }
}