using DaLatFood.Application.Base;
using DaLatFood.Application.Production.Dto;

namespace DaLatFood.Application.Production.Service;

public interface IProductService : ICrudService<Domain.Product.Entity.Production, ProductListDto, ProductDetailDto,
    ProductCreateDto, ProductUpdateDto>
{
}