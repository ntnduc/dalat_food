using DaLatFood.Domain.Product.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DaLatFood.Application.Production.Service;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<object> GetProductionAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Domain.Product.Entity.Production>> GetListProductionAsync()
    {
        var qb =await _productRepository.GetQueryableAsync();
        var result = await qb.ToListAsync();
        return result;
    }
}