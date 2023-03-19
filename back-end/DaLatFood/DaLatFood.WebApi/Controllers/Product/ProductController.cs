using DaLatFood.Application.Production.Dto;
using DaLatFood.Application.Production.Service;
using DaLatFood.Domain.Product.Entity;
using DaLatFood.WebApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace DaLatFood.WebApi.Controllers.Product;

[ApiController]
[Route("/api/product")]
public class ProductController : CrudControllerBase<Production, ProductListDto,ProductListDto,ProductListDto,ProductListDto>
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService) : base(productService)
    {
        _productService = productService;
    }
}