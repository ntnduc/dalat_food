using AutoMapper;
using DaLatFood.Application.Base;
using DaLatFood.Application.Production.Dto;
using DaLatFood.Domain.Product.Repositories;

namespace DaLatFood.Application.Production.Service;

public class ProductService : CrudService<Domain.Product.Entity.Production, ProductListDto, ProductListDto,
    ProductListDto, ProductListDto>, IProductService
{
    public ProductService(IProductRepository productRepository, IMapper mapper) :
        base(productRepository, mapper)
    {
    }
}