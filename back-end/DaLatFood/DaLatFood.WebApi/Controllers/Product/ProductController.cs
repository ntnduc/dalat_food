using DaLatFood.Application.Production.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DaLatFood.WebApi.Controllers.Product;

[ApiController]
[Route("/api/product")]
public class ProductController : ControllerBase
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("list")]
    [AllowAnonymous]
    public Task<List<Domain.Product.Entity.Production>> GetListProduct()
    {
        return _productService.GetListProductionAsync();
    }
}