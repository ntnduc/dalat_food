using AutoMapper;
using DaLatFood.Application.Production.Dto;

namespace DaLatFood.Application.Production.Mapper;

public class MapProductProfile : Profile 
{
    public MapProductProfile()
    {
        CreateMap<Domain.Product.Entity.Production, ProductListDto>();
        CreateMap<ProductListDto, Domain.Product.Entity.Production>();
        CreateMap<Domain.Product.Entity.Production, ProductDetailDto>();
        CreateMap<ProductDetailDto,Domain.Product.Entity.Production>();
        CreateMap<ProductCreateDto,Domain.Product.Entity.Production>();
        CreateMap<Domain.Product.Entity.Production, ProductCreateDto>();
        CreateMap<ProductUpdateDto,Domain.Product.Entity.Production>();
        CreateMap<Domain.Product.Entity.Production, ProductUpdateDto>();
    }
}