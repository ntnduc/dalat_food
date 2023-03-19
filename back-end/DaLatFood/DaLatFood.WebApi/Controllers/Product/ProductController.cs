using DaLatFood.Application.Common;
using DaLatFood.Application.Production.Dto;
using DaLatFood.Application.Production.Service;
using DaLatFood.Domain.Core.Response;
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
    public async Task<ApiResponse<PaginatedList<ProductListDto>>> GetListProduct(CancellationToken cancellationToken = default (CancellationToken))
    {
        var listResult = await _productService.GetListAsync(cancellationToken);
        return ApiResponse<PaginatedList<ProductListDto>>.Ok(listResult);
    }
}